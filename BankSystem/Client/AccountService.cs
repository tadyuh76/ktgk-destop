using Data;
using Models;

namespace Client
{
    internal class AccountService
    {
        public readonly AppDbContext _context;

        public AccountService()
        {
            _context = new AppDbContext();
        }

        public BankAccount Authenticate(long accountId, string password)
        {
            return _context.BankAccounts
                .FirstOrDefault(b => b.AccountId == accountId && b.Password == password);
        }

        public BankAccount GetAccountInfo(long accountId)
        {
            return _context.BankAccounts
                .FirstOrDefault(b => b.AccountId == accountId);
        }

        public List<Transaction> GetTransactions(long accountId)
        {
            return _context.Transactions
                .Where(t => t.AccountId == accountId)
                .OrderByDescending(t => t.HappenedTime)
                .ToList();
        }

        public bool Deposit(long accountId, double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var account = _context.BankAccounts
                        .FirstOrDefault(b => b.AccountId == accountId);
                    if (account == null)
                    {
                        return false;
                    }

                    account.Balance += amount;

                    _context.Transactions.Add(new Transaction
                    {
                        TransId = Guid.NewGuid(),
                        AccountId = accountId,
                        HappenedTime = DateTime.Now,
                        ActionDesc = "Deposit",
                        Note = $"Deposited {amount} to account {accountId}"
                    });
                    _context.SaveChanges();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

    }
}

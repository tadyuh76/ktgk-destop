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

        //public BankAccount Authenticate(long accountId, string password)
        //{

        //}
    }
}

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BankAccount
    {
        [Key]
        public long AccountId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerPhone { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

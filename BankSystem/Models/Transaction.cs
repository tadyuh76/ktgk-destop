
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Transaction
    {
        [Key]
        public Guid TransId { get; set; }
        public long AccountId { get; set; }
        public DateTime HappenedTime { get; set; }
        public string ActionDesc { get; set; }
        public string Note { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }
}

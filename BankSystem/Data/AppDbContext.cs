using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public string DBPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dataFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Data"));

            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }

            var dbPath = Path.Combine(dataFolder, "BankingSystem.db");
            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasOne(t => t.BankAccount).WithMany(b => b.Transactions).HasForeignKey(t => t.AccountId);
            modelBuilder.Entity<BankAccount>().HasData(
                new BankAccount
                {
                    AccountId = 1,
                    OwnerName = "Huy Huong",
                    OwnerAddress = "17 Nguyen Tri Phuong St.",
                    OwnerPhone = "0914398183",
                    Balance = 1000,
                    AccountType = "Checking",
                    Password = "123456",
                },
                new BankAccount
                {
                    AccountId = 2,
                    OwnerName = "Quan Hoang",
                    OwnerAddress = "18 Nguyen Tri Phuong St.",
                    OwnerPhone = "0914398184",
                    Balance = 2000,
                    AccountType = "Checking",
                    Password = "123456",
                },
                new BankAccount
                {
                    AccountId = 3,
                    OwnerName = "Quang Tran",
                    OwnerAddress = "19 Nguyen Tri Phuong St.",
                    OwnerPhone = "0914398185",
                    Balance = 3000,
                    AccountType = "Checking",
                    Password = "123456",
                }
            );
        }
    }
}

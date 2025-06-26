using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext>options) : base(options) 
        { }  

        public DbSet<Transaction> Transactions { get; set; }
    }
}


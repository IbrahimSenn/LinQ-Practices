

using Microsoft.EntityFrameworkCore;

namespace LinqPractices.DbOperations
{
    public class LinqDbContext : DbContext
    {
        public DbSet<Student> Students {get; set;}    //DbSet varlığı eklememizi sağlıyor.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName:"LinqDatabase");
        }
    }
}
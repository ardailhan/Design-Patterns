using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Arda\\SQLEXPRESS;initial catalog=DesignPattern2; integrated security=true;");
        }
        public DbSet<Product> Products{ get; set; }
    }
}

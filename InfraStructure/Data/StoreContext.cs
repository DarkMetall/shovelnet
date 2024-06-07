

using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data
{
    public class StoreContext : DbContext //session with our database
    {
        public StoreContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Product> Products{ get; set; }
    }
}
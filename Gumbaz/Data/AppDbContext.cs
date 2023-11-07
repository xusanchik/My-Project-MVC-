using Gumbaz.Entity;
using Microsoft.EntityFrameworkCore;

namespace Gumbaz.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coment> Coments { get; set; }  
        public DbSet<Contact> Contacts{ get; set; }
    }
}

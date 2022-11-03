using Microsoft.EntityFrameworkCore;
using System.Text;
using ZooWebAPI.Models;

namespace ZooWebAPI.DAL
{
    public class ZooDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public ZooDbContext(DbContextOptions<ZooDbContext> options)
            : base(options)
        {

        }
    }
}

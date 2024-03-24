using Kurs_v3.DB.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace Kurs_v3.DB
{
    public class Context: DbContext
    {
        public DbSet<Plate> Plates { get; set; }
        public DbSet<Dial> Dials { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<Assembly> Assemblies { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LapTop"].ConnectionString);

        }
    }
}

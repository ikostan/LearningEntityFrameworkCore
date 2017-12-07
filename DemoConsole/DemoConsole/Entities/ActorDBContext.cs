using Microsoft.EntityFrameworkCore;

namespace DemoConsole.Entities
{
    class ActorDBContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBulder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog=ActorDb;
                    Integrated Security=True;
                    Connect Timeout=30;
                    Encrypt=False;
                    TrustServerCertificate=True;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False");
        }
    }
}

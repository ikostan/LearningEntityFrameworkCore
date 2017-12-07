using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExistingDbMVCWebApplication.Models
{
    public partial class ActorDbContext : DbContext
    {
        public virtual DbSet<Actors> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=ActorDb;Trusted_Connection=True;");
        //            }
        //        }


    }
}

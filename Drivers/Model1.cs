using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Drivers
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<drivers> drivers { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Licences> Licences { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<drivers>()
                .HasMany(e => e.Licences)
                .WithOptional(e => e.drivers)
                .HasForeignKey(e => e.id_driver);
        }
    }
}

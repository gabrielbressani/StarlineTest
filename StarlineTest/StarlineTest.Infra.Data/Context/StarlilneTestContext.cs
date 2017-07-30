using StarlineTest.Domain.Entities;
using StarlineTest.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace StarlineTest.Infra.Data.Context
{
    public class StarlilneTestContext : DbContext
    {
        public StarlilneTestContext()
            : base ("StarlilneTestConnection")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                    .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
               .Configure(p => p.HasMaxLength(100));

            modelBuilder
                .Configurations
                    .Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("RegistrationDate").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}

using StarlineTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarlineTest.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);

            Property(u => u.Nome)
                .HasMaxLength(200)
                    .IsRequired();
        }
    }
}

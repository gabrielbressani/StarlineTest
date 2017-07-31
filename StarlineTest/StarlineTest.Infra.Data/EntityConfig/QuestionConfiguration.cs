using StarlineTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace StarlineTest.Infra.Data.EntityConfig
{
    public class QuestionConfiguration : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            HasKey(q => q.QuestionId);

            Property(q => q.TypeOfQuestion)
                .HasColumnType("int")
                    .IsRequired();

            Property(q => q.Enunciated)
                .HasMaxLength(400)
                    .IsRequired();

            Property(q => q.Answers)
                .HasMaxLength(400)
                    .IsOptional();

            HasRequired(u => u.User)
                .WithMany()
                    .HasForeignKey(u => u.UserId);
        }
    }
}

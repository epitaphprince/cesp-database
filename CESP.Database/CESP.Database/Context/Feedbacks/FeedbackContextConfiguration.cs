using CESP.Database.Context.Feedbacks.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Feedbacks
{
    public static class FeedbackContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureFeedbackSourceTable(modelBuilder);
            ConfigureFeedbackTable(modelBuilder);
            
            FeedbackSourseSeed.Seed(modelBuilder);
        }
        
        private static void ConfigureFeedbackTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackDto>(entity =>
            {
                entity.ToTable("feedbacks");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsRequired();

                entity.Property(e => e.Date)
                    .HasColumnName("date");
                
                entity.Property(e => e.FirstName)
                    .HasColumnName("firstname");
                
                entity.Property(e => e.LastName)
                    .HasColumnName("lastname");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Source)
                    .WithMany()
                    .HasForeignKey(e => e.SourceId)
                    .HasConstraintName("feedback_source_fk")
                    .OnDelete(DeleteBehavior.SetNull);
                
                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("feedback_photo_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }

        private static void ConfigureFeedbackSourceTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackSourceDto>(entity =>
            {
                entity.ToTable("feedback_sources");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");
            });
        }
    }
}
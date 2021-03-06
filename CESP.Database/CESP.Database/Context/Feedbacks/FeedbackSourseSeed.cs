using CESP.Database.Context.Feedbacks.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Feedbacks
{
    public static class FeedbackSourseSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackSourceDto>()
                .HasData(new FeedbackSourceDto
                {
                    Id = (int) FeedbackSourceEnum.Fb,
                    Name = "facebook",
                });
            modelBuilder.Entity<FeedbackSourceDto>()
                .HasData(
                    new FeedbackSourceDto
                    {
                        Id = (int) FeedbackSourceEnum.Vk,
                        Name = "vk",
                    });
            modelBuilder.Entity<FeedbackSourceDto>()
                .HasData(
                    new FeedbackSourceDto
                    {
                        Id = (int) FeedbackSourceEnum.Mail,
                        Name = "e-mail",
                    });
            modelBuilder.Entity<FeedbackSourceDto>()
                .HasData(
                    new FeedbackSourceDto
                    {
                        Id = (int) FeedbackSourceEnum.Worksheet,
                        Name = "анкета",
                    });        
        }
    }
}
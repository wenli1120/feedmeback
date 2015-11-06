namespace FeedMeBack.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FeedMeBack.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FeedMeBack.Models.FeedMeBackContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FeedMeBack.Models.FeedMeBackContext context)
        {
            context.Feedbacks.AddOrUpdate(p => p.CreatedOn,
               new Feedback
               {
                   UserId = "xxx",
                   UserName = "Wen Li",
                   UserIpAddress = "0.0.0.0",
                   Key = "080d115b-54ca-4845-a9ac-acb1d4849554",
                   System = "PIMS",
                   CreatedOn = DateTime.Today,
                   Message = "Great system!"
               },
                new Feedback
               {
                   UserId = "xxx",
                   UserName = "Wen Li",
                   UserIpAddress = "0.0.0.0",
                   System = "PIMS",
                   CreatedOn = DateTime.Today,
                   Message = "I love it!"
               }
            );

        }
    }
}

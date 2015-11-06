namespace FeedMeBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "UserId", c => c.String());
            AddColumn("dbo.Feedbacks", "UserName", c => c.String());
            AddColumn("dbo.Feedbacks", "UserIpAddress", c => c.String());
            DropColumn("dbo.Feedbacks", "NetworkLoginId");
            DropColumn("dbo.Feedbacks", "UserFirstName");
            DropColumn("dbo.Feedbacks", "UserLastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feedbacks", "UserLastName", c => c.String());
            AddColumn("dbo.Feedbacks", "UserFirstName", c => c.String());
            AddColumn("dbo.Feedbacks", "NetworkLoginId", c => c.String());
            DropColumn("dbo.Feedbacks", "UserIpAddress");
            DropColumn("dbo.Feedbacks", "UserName");
            DropColumn("dbo.Feedbacks", "UserId");
        }
    }
}

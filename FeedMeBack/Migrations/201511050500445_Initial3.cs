namespace FeedMeBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "Key", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feedbacks", "Key");
        }
    }
}

namespace FeedMeBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemKeys", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemKeys", "Url");
        }
    }
}

namespace FeedMeBack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SystemKeys", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SystemKeys", "UserId", c => c.Int(nullable: false));
        }
    }
}

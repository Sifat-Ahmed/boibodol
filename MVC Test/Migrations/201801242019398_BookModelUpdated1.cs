namespace MVC_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModelUpdated1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comment", "UserId");
        }
    }
}

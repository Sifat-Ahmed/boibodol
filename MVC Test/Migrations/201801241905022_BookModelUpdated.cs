namespace MVC_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModelUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Book", "AuthorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Book", "AuthorId", c => c.Int(nullable: false));
            DropColumn("dbo.Book", "UserId");
        }
    }
}

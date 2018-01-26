namespace MVC_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "Book_Id", c => c.Int());
            CreateIndex("dbo.Book", "CategoryId");
            CreateIndex("dbo.Book", "PostTypeId");
            CreateIndex("dbo.Book", "UserId");
            CreateIndex("dbo.Comment", "PostTypeId");
            CreateIndex("dbo.Comment", "UserId");
            CreateIndex("dbo.Comment", "Book_Id");
            CreateIndex("dbo.UserDetails", "UserId");
            AddForeignKey("dbo.Book", "CategoryId", "dbo.Category", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Book", "PostTypeId", "dbo.PostType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Book", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comment", "Book_Id", "dbo.Book", "Id");
            AddForeignKey("dbo.Comment", "PostTypeId", "dbo.PostType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comment", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserDetails", "UserId", "dbo.User", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.Comment", "UserId", "dbo.User");
            DropForeignKey("dbo.Comment", "PostTypeId", "dbo.PostType");
            DropForeignKey("dbo.Comment", "Book_Id", "dbo.Book");
            DropForeignKey("dbo.Book", "UserId", "dbo.User");
            DropForeignKey("dbo.Book", "PostTypeId", "dbo.PostType");
            DropForeignKey("dbo.Book", "CategoryId", "dbo.Category");
            DropIndex("dbo.UserDetails", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "Book_Id" });
            DropIndex("dbo.Comment", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "PostTypeId" });
            DropIndex("dbo.Book", new[] { "UserId" });
            DropIndex("dbo.Book", new[] { "PostTypeId" });
            DropIndex("dbo.Book", new[] { "CategoryId" });
            DropColumn("dbo.Comment", "Book_Id");
        }
    }
}

namespace MVC_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfirmPasswordAddedWithDataType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "ConfirmPassword");
        }
    }
}

namespace ToDo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editContentColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notes", "content", c => c.String());
        }
    }
}

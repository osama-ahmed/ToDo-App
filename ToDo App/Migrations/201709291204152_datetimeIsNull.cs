namespace ToDo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimeIsNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notes", "date", c => c.DateTime(nullable: false));
        }
    }
}

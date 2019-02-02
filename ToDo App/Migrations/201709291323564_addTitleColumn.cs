namespace ToDo_App.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class addTitleColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "title", c => c.String());
            AlterColumn("dbo.Notes", "date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notes", "date", c => c.DateTime());
            DropColumn("dbo.Notes", "title");
        }
    }
}

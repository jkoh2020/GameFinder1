namespace GameFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdtrial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameSystem", "GameSystemTitle", c => c.String());
            DropColumn("dbo.GameSystem", "GameTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameSystem", "GameTitle", c => c.String());
            DropColumn("dbo.GameSystem", "GameSystemTitle");
        }
    }
}

namespace GameFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firsttrial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameSystem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        OwnerId = c.Guid(nullable: false),
                        GameTitle = c.String(),
                        Description = c.String(),
                        GameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Game", t => t.GameId, cascadeDelete: true)
                .Index(t => t.GameId);
            
            AddColumn("dbo.Game", "Genre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameSystem", "GameId", "dbo.Game");
            DropIndex("dbo.GameSystem", new[] { "GameId" });
            DropColumn("dbo.Game", "Genre");
            DropTable("dbo.GameSystem");
        }
    }
}

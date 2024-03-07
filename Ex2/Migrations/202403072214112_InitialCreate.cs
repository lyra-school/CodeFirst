namespace Ex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LocationName = c.String(),
                        ComputerGameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.ComputerGames", t => t.ComputerGameId, cascadeDelete: true)
                .Index(t => t.ComputerGameId);
            
            CreateTable(
                "dbo.ComputerGames",
                c => new
                    {
                        ComputerGameId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.ComputerGameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "ComputerGameId", "dbo.ComputerGames");
            DropIndex("dbo.Characters", new[] { "ComputerGameId" });
            DropTable("dbo.ComputerGames");
            DropTable("dbo.Characters");
        }
    }
}

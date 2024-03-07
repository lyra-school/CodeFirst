namespace Ex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class charimg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "CharacterImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "CharacterImage");
        }
    }
}

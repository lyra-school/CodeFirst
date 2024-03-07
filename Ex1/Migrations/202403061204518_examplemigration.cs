namespace Ex1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class examplemigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "StadiumName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "StadiumName");
        }
    }
}

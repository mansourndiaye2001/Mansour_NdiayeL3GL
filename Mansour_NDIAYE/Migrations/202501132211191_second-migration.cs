namespace Mansour_NDIAYE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Etudiants", "Nom", c => c.String());
            DropColumn("dbo.Etudiants", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Etudiants", "Name", c => c.String());
            DropColumn("dbo.Etudiants", "Nom");
        }
    }
}

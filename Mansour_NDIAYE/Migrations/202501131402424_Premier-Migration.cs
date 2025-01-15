namespace Mansour_NDIAYE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PremierMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        Name = c.String(),
                        Prenom = c.String(),
                        Idclasse = c.Int(nullable: false),
                        C_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.C_Id)
                .Index(t => t.C_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etudiants", "C_Id", "dbo.Classes");
            DropIndex("dbo.Etudiants", new[] { "C_Id" });
            DropTable("dbo.Etudiants");
            DropTable("dbo.Classes");
        }
    }
}

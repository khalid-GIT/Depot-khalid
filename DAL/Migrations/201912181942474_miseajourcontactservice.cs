namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miseajourcontactservice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Client",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Adresse = c.String(),
                        Mail = c.String(),
                        telephone1 = c.String(),
                        fax = c.String(),
                        DatedeCreation = c.DateTime(),
                        idf = c.String(),
                        Cnss = c.String(),
                        Ice = c.String(),
                        Gsm = c.String(),
                        Teleph = c.String(),
                        IdVille = c.Int(nullable: false),
                        IdFamille = c.Int(nullable: false),
                        IDContact = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Tbl_Contact_Clt", t => t.IDContact, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Famille_Clt", t => t.IdFamille, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Ville", t => t.IdVille, cascadeDelete: true)
                .Index(t => t.IdVille)
                .Index(t => t.IdFamille)
                .Index(t => t.IDContact);
            
            CreateTable(
                "dbo.Tbl_Contact_Clt",
                c => new
                    {
                        IDContact = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Gsm = c.String(),
                        Email = c.String(),
                        IDService = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDContact)
                .ForeignKey("dbo.Tbl_Service", t => t.IDService, cascadeDelete: true)
                .Index(t => t.IDService);
            
            CreateTable(
                "dbo.Tbl_Service",
                c => new
                    {
                        IDService = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                    })
                .PrimaryKey(t => t.IDService);
            
            CreateTable(
                "dbo.Tbl_Famille_Clt",
                c => new
                    {
                        IdFamille = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.IdFamille);
            
            CreateTable(
                "dbo.Tbl_Ville",
                c => new
                    {
                        IdVille = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                    })
                .PrimaryKey(t => t.IdVille);
            
            CreateTable(
                "dbo.Tbl_Region",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tbl_Client", "IdVille", "dbo.Tbl_Ville");
            DropForeignKey("dbo.Tbl_Client", "IdFamille", "dbo.Tbl_Famille_Clt");
            DropForeignKey("dbo.Tbl_Client", "IDContact", "dbo.Tbl_Contact_Clt");
            DropForeignKey("dbo.Tbl_Contact_Clt", "IDService", "dbo.Tbl_Service");
            DropIndex("dbo.Tbl_Contact_Clt", new[] { "IDService" });
            DropIndex("dbo.Tbl_Client", new[] { "IDContact" });
            DropIndex("dbo.Tbl_Client", new[] { "IdFamille" });
            DropIndex("dbo.Tbl_Client", new[] { "IdVille" });
            DropTable("dbo.Tbl_Region");
            DropTable("dbo.Tbl_Ville");
            DropTable("dbo.Tbl_Famille_Clt");
            DropTable("dbo.Tbl_Service");
            DropTable("dbo.Tbl_Contact_Clt");
            DropTable("dbo.Tbl_Client");
        }
    }
}

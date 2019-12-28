namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versioN211219 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tbl_Client", "CodePostal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tbl_Client", "CodePostal");
        }
    }
}

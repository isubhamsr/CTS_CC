namespace CTS_CC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmplyeeAndAddressModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        Code = c.String(nullable: false),
                        AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId)
                .Index(t => t.AddressId);
            
            AlterColumn("dbo.Members", "_address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Employees", new[] { "AddressId" });
            AlterColumn("dbo.Members", "_address", c => c.String());
            DropTable("dbo.Employees");
            DropTable("dbo.Addresses");
        }
    }
}

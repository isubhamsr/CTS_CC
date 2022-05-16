namespace CTS_CC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inisial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        _name = c.String(),
                        _address = c.String(),
                        _isVoted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t._id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}

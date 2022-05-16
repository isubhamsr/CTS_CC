namespace CTS_CC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVoterIdToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "_voterId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "_voterId");
        }
    }
}

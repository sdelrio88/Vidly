namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "Duration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Duration", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
    }
}

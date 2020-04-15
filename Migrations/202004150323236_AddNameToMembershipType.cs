namespace CobaMVCNetFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("Update MembershipTypes SET Name = 'Pay as You Go' where Id = 1");
            Sql("Update MembershipTypes SET Name = 'Monthly' where Id = 2");
            Sql("Update MembershipTypes SET Name = 'Quarterly' where Id = 3");
            Sql("Update MembershipTypes SET Name = 'Annualy' where Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}

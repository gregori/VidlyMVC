namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET Name = 'Paga Conforme Uso' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Mensal' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quadrimestral' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Anual' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}

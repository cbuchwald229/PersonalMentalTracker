namespace PersonalMentalHealthTracker.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationWithEntriesAndUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entries", "UserId", c => c.String());
            DropColumn("dbo.Entries", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entries", "Username", c => c.String());
            DropColumn("dbo.Entries", "UserId");
        }
    }
}

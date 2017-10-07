namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSpellingOfSomeTableColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Gigs", "IsCancelled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "IsCancelled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Gigs", "IsCanceled");
        }
    }
}

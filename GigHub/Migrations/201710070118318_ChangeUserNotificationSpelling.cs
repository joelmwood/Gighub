namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserNotificationSpelling : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserNotificiations", newName: "UserNotifications");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserNotifications", newName: "UserNotificiations");
        }
    }
}

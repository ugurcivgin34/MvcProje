namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_addMessageClassUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ReceiverMail", c => c.String(maxLength: 50));
            AddColumn("dbo.Messages", "Subject", c => c.String(maxLength: 50));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String());
            DropColumn("dbo.Messages", "SubjectMail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "SubjectMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 100));
            DropColumn("dbo.Messages", "Subject");
            DropColumn("dbo.Messages", "ReceiverMail");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String());
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
        }
    }
}

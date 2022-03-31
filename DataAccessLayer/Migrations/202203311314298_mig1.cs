namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterImage");
        }
    }
}

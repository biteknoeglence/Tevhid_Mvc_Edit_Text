namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterPassword");
            DropColumn("dbo.Writers", "WriterAbout");
            DropColumn("dbo.Writers", "WriterImage");
        }
    }
}

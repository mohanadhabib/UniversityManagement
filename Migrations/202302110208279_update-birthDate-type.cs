namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatebirthDatetype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
            DropColumn("dbo.Teachers", "BirthDate");
        }
    }
}

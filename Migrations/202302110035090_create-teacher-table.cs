namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createteachertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Ssn = c.Int(nullable: false),
                        Gender = c.String(maxLength: 6),
                        Phone = c.String(),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}

namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtablestudentteacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentTeachers",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.TeacherId })
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentTeachers", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentTeachers", new[] { "TeacherId" });
            DropIndex("dbo.StudentTeachers", new[] { "StudentId" });
            DropTable("dbo.StudentTeachers");
        }
    }
}

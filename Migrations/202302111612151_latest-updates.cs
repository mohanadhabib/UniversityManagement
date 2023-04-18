namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestupdates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentTeachers", "StudentId", "dbo.Students");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Teachers");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Teachers", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentTeachers", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentTeachers", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTeachers", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Teachers");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Teachers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Teachers", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            AddForeignKey("dbo.StudentTeachers", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentTeachers", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}

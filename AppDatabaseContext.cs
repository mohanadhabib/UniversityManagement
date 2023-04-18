using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext() : base("data source = MOHANAD\\SQLEXPRESS;database = UniversityDB; integrated security = true; encrypt = false;") { }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }   
        public DbSet<Course>? Courses { get; set; }     
        public DbSet<StudentTeacher>? StudentTeachers { get; set; } 
        public DbSet<StudentCourse>? StudentCourses { get; set; }

    }
}

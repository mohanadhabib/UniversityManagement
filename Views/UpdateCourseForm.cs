using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Views
{
    public partial class updateCourseForm : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public updateCourseForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course();
                Teacher teacher = new Teacher(); 
                int teacherId;
                int id = int.Parse(txtId.Text);
                course = db.Courses!.Where(e => e.Id == id).First();
                teacher = db.Teachers!.Where(e => e.Name == txtTeacher.Text).First();
                teacherId = teacher.Id;
                course.Name = txtName.Text;
                course.CreditHours = int.Parse(txtCreditHours.Text);
                course.TeacherId = teacherId;
                db.Courses.AddOrUpdate(course);
                db.SaveChanges();
                this.Close();
                showCoursesForm.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Couldn\'t update record");
                this.Close();
            }
        }
    }
}

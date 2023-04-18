using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Views
{
    public partial class showCoursesForm : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public showCoursesForm()
        {
            InitializeComponent();
        }

        private void ShowCoursesForm_Load(object sender, EventArgs e)
        {
            courseForm.ActiveForm.Close();  
            dataGridViewCourse.DataSource = db.Courses!.ToList();
            dataGridViewCourse.Columns.Remove("Teacher");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course();
                Course c = new Course();
                course.Id = int.Parse(dataGridViewCourse.SelectedCells[0].Value.ToString()!);
                c = db.Courses!.Where(e => e.Id == course.Id).First();
                db.Courses!.Remove(c);
                db.SaveChanges();
                dataGridViewCourse.DataSource = db.Courses.ToList();
                dataGridViewCourse.Columns.Remove("Teacher");
            }
            catch
            {
                MessageBox.Show("Couldn\'t delete a record");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateCourseForm updateCourseForm = new updateCourseForm();
            updateCourseForm.Show();
        }
    }
}

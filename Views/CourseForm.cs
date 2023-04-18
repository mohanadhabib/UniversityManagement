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
    public partial class courseForm : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        static Course course = new Course();
        public courseForm()
        {
            InitializeComponent();
        }
        public Course sendCourseObject()
        {
            return course;
        }

        private void btnAddId_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                courseAddById c1 = new courseAddById();
                course.Id = int.Parse(txtId.Text);
                course.Name = txtName.Text;
                course.CreditHours = int.Parse(txtCreditHours.Text);
                c1.Show();
                txtId.Clear();
                txtName.Clear();
                txtCreditHours.Clear();
            }
            catch
            {
                MessageBox.Show("Please fill all fields");
            }
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                courseAddByName c1 = new courseAddByName();
                course.Id = int.Parse(txtId.Text);
                course.Name = txtName.Text;
                course.CreditHours = int.Parse(txtCreditHours.Text);
                c1.Show();
                txtId.Clear();
                txtName.Clear();
                txtCreditHours.Clear();
            }
            catch
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showCoursesForm showCoursesForm = new showCoursesForm();
            showCoursesForm.Show();
        }
    }
}

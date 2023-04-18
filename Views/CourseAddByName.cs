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
using System.Xml.Linq;

namespace Final_Project.Views
{
    public partial class courseAddByName : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public courseAddByName()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                courseForm course = new courseForm();
                Course c = new Course();
                Teacher teacher = new Teacher();
                teacher = db.Teachers!.Where(t => t.Name == txtName.Text).First();
                course.sendCourseObject().TeacherId = teacher.Id;
                c.Id = course.sendCourseObject().Id;
                c.Name = course.sendCourseObject().Name;
                c.CreditHours = course.sendCourseObject().CreditHours;
                c.TeacherId = course.sendCourseObject().TeacherId;
                db.Courses!.Add(c);
                db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Couldn\'t add course");
                this.Close();
            }
        }
    }
}

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
    public partial class courseAddById : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public courseAddById()
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
                int id = int.Parse(txtId.Text);
                teacher = db.Teachers!.Where(e => e.Id == id).First();
                c.Id = course.sendCourseObject().Id;
                c.Name = course.sendCourseObject().Name;
                c.CreditHours = course.sendCourseObject().CreditHours;
                c.TeacherId = teacher.Id;
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

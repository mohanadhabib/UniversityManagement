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
    public partial class updateStudentForm : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public updateStudentForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Student std = new Student();
                int id = int.Parse(txtId.Text);
                std = db.Students!.Where(e => e.Id == id).First();
                std.Ssn = int.Parse(txtSsn.Text);
                std.Name = txtName.Text;
                std.BirthDate = DateTime.Parse(pickerBirthDate.Value.ToString());
                std.Gender = pickerGender.Text;
                std.Phone = txtPhone.Text;
                std.Gpa = float.Parse(txtGpa.Text);
                db.Students.AddOrUpdate(std);
                db.SaveChanges();
                this.Close();
                showStudentForm.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Couldn\'t update record");
                this.Close();
            }
        }
    }
}

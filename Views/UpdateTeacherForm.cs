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
    public partial class updateTeacherForm : Form
    {
        AppDatabaseContext db = new AppDatabaseContext();
        public updateTeacherForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                int id = int.Parse(txtId.Text);
                teacher = db.Teachers!.Where(e => e.Id == id).First();
                teacher.Ssn = int.Parse(txtSsn.Text);
                teacher.Name = txtName.Text;
                teacher.BirthDate = DateTime.Parse(pickerBirthDate.Value.ToString());
                teacher.Gender = pickerGender.Text;
                teacher.Phone = txtPhone.Text;
                teacher.Salary = float.Parse(txtSalary.Text);
                db.Teachers.AddOrUpdate(teacher);
                db.SaveChanges();
                this.Close();
                showTeacherForm.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Couldn\'t update record");
                this.Close();
            }
        }
    }
}

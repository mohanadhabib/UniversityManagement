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
    public partial class teacherForm : Form
    {
        public teacherForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AppDatabaseContext db = new AppDatabaseContext();
                Teacher teacher = new Teacher();
                teacher.Id = int.Parse(txtId.Text);
                teacher.Ssn = int.Parse(txtSsn.Text);
                teacher.Name = txtName.Text;
                teacher.BirthDate = pickerBirthDate.Value;
                teacher.Gender = pickerGender.SelectedItem.ToString();
                teacher.Phone = txtPhone.Text;
                teacher.Salary = float.Parse(txtSalary.Text);
                db.Teachers!.Add(teacher);
                db.SaveChanges();
                MessageBox.Show("Teacher Added Successfully");
                txtId.Clear();
                txtSsn.Clear();
                txtName.Clear();
                pickerBirthDate.Value = DateTime.Now;
                pickerGender.SelectedItem = null;
                txtPhone.Clear();
                txtSalary.Clear();
            }
            catch
            {
                MessageBox.Show("Couldn\'t add teacher");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showTeacherForm showTeacherForm = new showTeacherForm();
            showTeacherForm.Show();
        }
    }
}

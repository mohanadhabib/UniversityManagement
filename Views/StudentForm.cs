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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AppDatabaseContext db = new AppDatabaseContext();
                Student student = new Student();
                student.Id = int.Parse(txtId.Text);
                student.Ssn = int.Parse(txtSsn.Text);
                student.Name = txtName.Text;
                student.BirthDate = pickerBirthDate.Value;
                student.Gender = pickerGender.SelectedItem.ToString();
                student.Phone = txtPhone.Text;
                student.Gpa = float.Parse(txtGpa.Text);
                db.Students!.Add(student);
                db.SaveChanges();
                MessageBox.Show("Student Added Successfully");
                txtId.Clear();
                txtSsn.Clear();
                txtName.Clear();
                pickerBirthDate.Value = DateTime.Now;
                pickerGender.SelectedItem = null;
                txtPhone.Clear();
                txtGpa.Clear();
            }
            catch
            {
                MessageBox.Show("Couldn\'t add student");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showStudentForm showStudentForm = new showStudentForm();
            showStudentForm.Show();
        }
    }
}

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
    public partial class showStudentForm : Form
    {
        public AppDatabaseContext db = new AppDatabaseContext();
        public showStudentForm()
        {
            InitializeComponent();
        }

        private void showStudentForm_Load(object sender, EventArgs e)
        {
            studentForm.ActiveForm.Close();
            dataGridViewStudent.DataSource = db.Students!.ToList(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStudentForm updateStudentForm = new updateStudentForm();  
            updateStudentForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                Student std = new Student();
                student.Id = int.Parse(dataGridViewStudent.SelectedCells[0].Value.ToString()!);
                std = db.Students!.Where(e => e.Id == student.Id).First();
                db.Students!.Remove(std);
                db.SaveChanges();
                dataGridViewStudent.DataSource = db.Students.ToList();
            }
            catch
            {
                MessageBox.Show("Couldn\'t delete a record");
            }
        }
    }
}

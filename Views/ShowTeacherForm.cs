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
    public partial class showTeacherForm : Form
    {
        public AppDatabaseContext db = new AppDatabaseContext();
        public showTeacherForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTeacherForm updateTeacherForm = new updateTeacherForm();
            updateTeacherForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                Teacher tch = new Teacher();
                teacher.Id = int.Parse(dataGridViewTeacher.SelectedCells[0].Value.ToString()!);
                tch = db.Teachers!.Where(e => e.Id == teacher.Id).First();
                db.Teachers!.Remove(tch);
                db.SaveChanges();
                dataGridViewTeacher.DataSource = db.Teachers.ToList();
            }
            catch
            {
                MessageBox.Show("Couldn\'t delete a record");
            }
        }

        private void showTeacherForm_Load(object sender, EventArgs e)
        {
            teacherForm.ActiveForm.Close();
            dataGridViewTeacher.DataSource = db.Teachers!.ToList();
        }
    }
}

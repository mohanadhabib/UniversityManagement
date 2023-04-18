using Final_Project.Views;

namespace Final_Project
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            studentForm studentForm = new studentForm();
            studentForm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            teacherForm teacherForm = new teacherForm();
            teacherForm.Show(); 
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            courseForm courseForm = new courseForm();
            courseForm.Show();  
        }
    }
}
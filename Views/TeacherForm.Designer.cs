namespace Final_Project.Views
{
    partial class teacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pickerGender = new System.Windows.Forms.ComboBox();
            this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(308, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 21);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Add a New Teacher";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(472, 400);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 50);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(212, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(366, 350);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 23);
            this.txtSalary.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(366, 300);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 29;
            // 
            // pickerGender
            // 
            this.pickerGender.FormattingEnabled = true;
            this.pickerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.pickerGender.Location = new System.Drawing.Point(366, 250);
            this.pickerGender.Name = "pickerGender";
            this.pickerGender.Size = new System.Drawing.Size(121, 23);
            this.pickerGender.TabIndex = 28;
            // 
            // pickerBirthDate
            // 
            this.pickerBirthDate.Location = new System.Drawing.Point(366, 200);
            this.pickerBirthDate.Name = "pickerBirthDate";
            this.pickerBirthDate.Size = new System.Drawing.Size(200, 23);
            this.pickerBirthDate.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(366, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 26;
            // 
            // txtSsn
            // 
            this.txtSsn.Location = new System.Drawing.Point(366, 100);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(100, 23);
            this.txtSsn.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(366, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 24;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(168, 358);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(38, 15);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(168, 308);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(168, 258);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(168, 208);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(59, 15);
            this.lblBirthDate.TabIndex = 20;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(168, 108);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(28, 15);
            this.lblSsn.TabIndex = 18;
            this.lblSsn.Text = "SSN";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(168, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pickerGender);
            this.Controls.Add(this.pickerBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblId);
            this.Name = "teacherForm";
            this.Text = "Teacher Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnShow;
        private Button btnAdd;
        private TextBox txtSalary;
        private TextBox txtPhone;
        private ComboBox pickerGender;
        private DateTimePicker pickerBirthDate;
        private TextBox txtName;
        private TextBox txtSsn;
        private TextBox txtId;
        private Label lblSalary;
        private Label lblPhone;
        private Label lblGender;
        private Label lblBirthDate;
        private Label lblName;
        private Label lblSsn;
        private Label lblId;
    }
}
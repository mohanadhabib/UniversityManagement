namespace Final_Project.Views
{
    partial class updateCourseForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblCreditHours = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(297, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 21);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Update Course";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(313, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 50);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(394, 261);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 23);
            this.txtTeacher.TabIndex = 46;
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(394, 209);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.Size = new System.Drawing.Size(100, 23);
            this.txtCreditHours.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(394, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(196, 109);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 41;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(196, 269);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(82, 15);
            this.lblTeacher.TabIndex = 39;
            this.lblTeacher.Text = "Teacher Name";
            // 
            // lblCreditHours
            // 
            this.lblCreditHours.AutoSize = true;
            this.lblCreditHours.Location = new System.Drawing.Point(196, 217);
            this.lblCreditHours.Name = "lblCreditHours";
            this.lblCreditHours.Size = new System.Drawing.Size(74, 15);
            this.lblCreditHours.TabIndex = 36;
            this.lblCreditHours.Text = "Credit Hours";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(196, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 117);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 15);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Search ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblCreditHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "updateCourseForm";
            this.Text = "Update Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnSubmit;
        private TextBox txtTeacher;
        private TextBox txtCreditHours;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblTeacher;
        private Label lblCreditHours;
        private Label lblName;
        private Label lblId;
    }
}
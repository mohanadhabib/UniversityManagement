namespace Final_Project.Views
{
    partial class courseForm
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
            this.btnAddId = new System.Windows.Forms.Button();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(309, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 21);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Add a New Course";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(280, 399);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 50);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddId
            // 
            this.btnAddId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddId.Location = new System.Drawing.Point(169, 301);
            this.btnAddId.Name = "btnAddId";
            this.btnAddId.Size = new System.Drawing.Size(106, 68);
            this.btnAddId.TabIndex = 31;
            this.btnAddId.Text = "Add By Teacher Id";
            this.btnAddId.UseVisualStyleBackColor = true;
            this.btnAddId.Click += new System.EventHandler(this.btnAddId_Click);
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(367, 200);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.Size = new System.Drawing.Size(100, 23);
            this.txtCreditHours.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(367, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(367, 100);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(169, 208);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 15);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Credit Hours";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(169, 158);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(39, 15);
            this.lblSsn.TabIndex = 18;
            this.lblSsn.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(169, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 15);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Course Code";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddName
            // 
            this.btnAddName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddName.Location = new System.Drawing.Point(361, 301);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(106, 68);
            this.btnAddName.TabIndex = 34;
            this.btnAddName.Text = "Add By Teacher Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // courseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAddId);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblId);
            this.Name = "courseForm";
            this.Text = "Course Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnShow;
        private Button btnAddId;
        private TextBox txtCreditHours;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblName;
        private Label lblSsn;
        private Label lblId;
        private Button btnAddName;
    }
}
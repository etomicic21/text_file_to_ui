namespace TextToFile
{
    partial class UserInfoForm
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtYearOfBirth = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(25, 12);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(103, 38);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(208, 83);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(238, 22);
            this.txtFullName.TabIndex = 2;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(208, 301);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(238, 22);
            this.txtRole.TabIndex = 4;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(22, 304);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role:";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(208, 241);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(238, 22);
            this.txtFaculty.TabIndex = 6;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(22, 241);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(53, 16);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Faculty:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(208, 188);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(238, 22);
            this.txtCity.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(22, 191);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // txtYearOfBirth
            // 
            this.txtYearOfBirth.Location = new System.Drawing.Point(208, 133);
            this.txtYearOfBirth.Name = "txtYearOfBirth";
            this.txtYearOfBirth.Size = new System.Drawing.Size(238, 22);
            this.txtYearOfBirth.TabIndex = 10;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(22, 133);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 16);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year of birth:";
            // 
            // txtAttribute
            // 
            this.txtAttribute.Location = new System.Drawing.Point(208, 359);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.Size = new System.Drawing.Size(238, 22);
            this.txtAttribute.TabIndex = 12;
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(22, 362);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(140, 16);
            this.lblAttribute.TabIndex = 11;
            this.lblAttribute.Text = "[role specific attribute]:";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 417);
            this.Controls.Add(this.txtAttribute);
            this.Controls.Add(this.lblAttribute);
            this.Controls.Add(this.txtYearOfBirth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChooseFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfoForm";
            this.ShowIcon = false;
            this.Text = "User data display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtYearOfBirth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtAttribute;
        private System.Windows.Forms.Label lblAttribute;
    }
}


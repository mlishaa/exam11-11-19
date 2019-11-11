namespace exam_01_11_11
{
    partial class Form1
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
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.teleph = new System.Windows.Forms.Label();
            this.clearForm = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.countOfUser = new System.Windows.Forms.Button();
            this.deleteUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(405, 77);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 20);
            this.fName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(405, 115);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 20);
            this.lName.TabIndex = 1;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(405, 157);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(100, 20);
            this.telephone.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(299, 83);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(61, 13);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "First name :";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(295, 115);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(62, 13);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last name :";
            // 
            // teleph
            // 
            this.teleph.AutoSize = true;
            this.teleph.Location = new System.Drawing.Point(291, 160);
            this.teleph.Name = "teleph";
            this.teleph.Size = new System.Drawing.Size(98, 13);
            this.teleph.TabIndex = 5;
            this.teleph.Text = "Telephone Nmber :";
            // 
            // clearForm
            // 
            this.clearForm.Location = new System.Drawing.Point(282, 240);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(107, 23);
            this.clearForm.TabIndex = 6;
            this.clearForm.Text = "Clear Form";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(439, 240);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(95, 23);
            this.register.TabIndex = 7;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // countOfUser
            // 
            this.countOfUser.Location = new System.Drawing.Point(282, 283);
            this.countOfUser.Name = "countOfUser";
            this.countOfUser.Size = new System.Drawing.Size(107, 23);
            this.countOfUser.TabIndex = 8;
            this.countOfUser.Text = "Count of Users";
            this.countOfUser.UseVisualStyleBackColor = true;
            this.countOfUser.Click += new System.EventHandler(this.countOfUser_Click);
            // 
            // deleteUsers
            // 
            this.deleteUsers.Location = new System.Drawing.Point(439, 282);
            this.deleteUsers.Name = "deleteUsers";
            this.deleteUsers.Size = new System.Drawing.Size(95, 23);
            this.deleteUsers.TabIndex = 9;
            this.deleteUsers.Text = "Delete Users";
            this.deleteUsers.UseVisualStyleBackColor = true;
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteUsers);
            this.Controls.Add(this.countOfUser);
            this.Controls.Add(this.register);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.teleph);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label teleph;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button countOfUser;
        private System.Windows.Forms.Button deleteUsers;
    }
}


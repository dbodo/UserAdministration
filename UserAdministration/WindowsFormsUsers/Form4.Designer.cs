namespace WindowsFormsUsers
{
    partial class FormAddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inptAddName = new System.Windows.Forms.TextBox();
            this.inptAddSurname = new System.Windows.Forms.TextBox();
            this.inptAddPassword = new System.Windows.Forms.TextBox();
            this.inptAddUsername = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUserExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // inptAddName
            // 
            this.inptAddName.Location = new System.Drawing.Point(90, 26);
            this.inptAddName.Name = "inptAddName";
            this.inptAddName.Size = new System.Drawing.Size(154, 20);
            this.inptAddName.TabIndex = 4;
            // 
            // inptAddSurname
            // 
            this.inptAddSurname.Location = new System.Drawing.Point(90, 56);
            this.inptAddSurname.Name = "inptAddSurname";
            this.inptAddSurname.Size = new System.Drawing.Size(154, 20);
            this.inptAddSurname.TabIndex = 5;
            // 
            // inptAddPassword
            // 
            this.inptAddPassword.Location = new System.Drawing.Point(90, 132);
            this.inptAddPassword.Name = "inptAddPassword";
            this.inptAddPassword.Size = new System.Drawing.Size(154, 20);
            this.inptAddPassword.TabIndex = 6;
            // 
            // inptAddUsername
            // 
            this.inptAddUsername.Location = new System.Drawing.Point(90, 95);
            this.inptAddUsername.Name = "inptAddUsername";
            this.inptAddUsername.Size = new System.Drawing.Size(154, 20);
            this.inptAddUsername.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(140, 202);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(121, 31);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "DODAJ KORISNIKA";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUserExit
            // 
            this.btnEditUserExit.Location = new System.Drawing.Point(12, 202);
            this.btnEditUserExit.Name = "btnEditUserExit";
            this.btnEditUserExit.Size = new System.Drawing.Size(108, 31);
            this.btnEditUserExit.TabIndex = 9;
            this.btnEditUserExit.Text = "Izlaz";
            this.btnEditUserExit.UseVisualStyleBackColor = true;
            this.btnEditUserExit.Click += new System.EventHandler(this.btnEditUserExit_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEditUserExit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.inptAddUsername);
            this.Controls.Add(this.inptAddPassword);
            this.Controls.Add(this.inptAddSurname);
            this.Controls.Add(this.inptAddName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddUser";
            this.Text = "Dodaj novog korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox inptAddName;
        public System.Windows.Forms.TextBox inptAddSurname;
        public System.Windows.Forms.TextBox inptAddPassword;
        public System.Windows.Forms.TextBox inptAddUsername;
        public System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUserExit;
    }
}
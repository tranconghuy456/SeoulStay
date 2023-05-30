namespace Module_1_Rebuilt
{
    partial class frm_Login
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_ShowPwd = new System.Windows.Forms.CheckBox();
            this.chk_RememberMe = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Emp = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(15, 48);
            userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(81, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Employee:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(15, 150);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(80, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 99);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_ShowPwd);
            this.groupBox1.Controls.Add(this.chk_RememberMe);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.txt_Emp);
            this.groupBox1.Location = new System.Drawing.Point(36, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // chk_ShowPwd
            // 
            this.chk_ShowPwd.Location = new System.Drawing.Point(409, 128);
            this.chk_ShowPwd.Margin = new System.Windows.Forms.Padding(4);
            this.chk_ShowPwd.Name = "chk_ShowPwd";
            this.chk_ShowPwd.Size = new System.Drawing.Size(174, 30);
            this.chk_ShowPwd.TabIndex = 0;
            this.chk_ShowPwd.Text = "Show Password";
            this.chk_ShowPwd.UseVisualStyleBackColor = true;
            this.chk_ShowPwd.CheckedChanged += new System.EventHandler(this.chk_ShowPwd_CheckedChanged);
            // 
            // chk_RememberMe
            // 
            this.chk_RememberMe.Location = new System.Drawing.Point(409, 65);
            this.chk_RememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.chk_RememberMe.Name = "chk_RememberMe";
            this.chk_RememberMe.Size = new System.Drawing.Size(174, 30);
            this.chk_RememberMe.TabIndex = 0;
            this.chk_RememberMe.Text = "Keep me signed in";
            this.chk_RememberMe.UseVisualStyleBackColor = true;
            this.chk_RememberMe.CheckedChanged += new System.EventHandler(this.chk_RememberMe_CheckedChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(116, 146);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(274, 28);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(116, 95);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(274, 28);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Emp
            // 
            this.txt_Emp.Location = new System.Drawing.Point(116, 44);
            this.txt_Emp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Emp.Name = "txt_Emp";
            this.txt_Emp.Size = new System.Drawing.Size(274, 28);
            this.txt_Emp.TabIndex = 1;
            this.txt_Emp.TextChanged += new System.EventHandler(this.txt_Emp_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btn_Exit.Image = global::Module_1_Rebuilt.Properties.Resources.login_box_line;
            this.btn_Exit.Location = new System.Drawing.Point(365, 356);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(106, 38);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btn_Register
            // 
            this.btn_Register.AutoSize = true;
            this.btn_Register.Location = new System.Drawing.Point(380, 408);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(83, 20);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.TabStop = true;
            this.btn_Register.Text = "Create one";
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::Module_1_Rebuilt.Properties.Resources.login_box_line;
            this.btn_Login.Location = new System.Drawing.Point(205, 356);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(106, 38);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Module_1_Rebuilt.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.pictureBox1.Location = new System.Drawing.Point(95, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(668, 451);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login";
            this.Text = "Seoul Stay - Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btn_Register;
        private System.Windows.Forms.TextBox txt_Emp;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.CheckBox chk_ShowPwd;
        private System.Windows.Forms.CheckBox chk_RememberMe;
    }
}


namespace Module_1
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.gr_Login = new System.Windows.Forms.GroupBox();
            this.chk_PassShow = new System.Windows.Forms.CheckBox();
            this.chk_KeepMeSignedIn = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Emp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_CreateAcc = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.gr_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(104, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(550, 100);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // gr_Login
            // 
            this.gr_Login.Controls.Add(this.chk_PassShow);
            this.gr_Login.Controls.Add(this.chk_KeepMeSignedIn);
            this.gr_Login.Controls.Add(this.txt_Password);
            this.gr_Login.Controls.Add(this.txt_Username);
            this.gr_Login.Controls.Add(this.txt_Emp);
            this.gr_Login.Controls.Add(this.label4);
            this.gr_Login.Controls.Add(this.label3);
            this.gr_Login.Controls.Add(this.label2);
            this.gr_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.gr_Login.Location = new System.Drawing.Point(57, 137);
            this.gr_Login.Name = "gr_Login";
            this.gr_Login.Size = new System.Drawing.Size(650, 225);
            this.gr_Login.TabIndex = 1;
            this.gr_Login.TabStop = false;
            this.gr_Login.Text = "Login";
            // 
            // chk_PassShow
            // 
            this.chk_PassShow.AutoSize = true;
            this.chk_PassShow.Location = new System.Drawing.Point(453, 139);
            this.chk_PassShow.Name = "chk_PassShow";
            this.chk_PassShow.Size = new System.Drawing.Size(169, 28);
            this.chk_PassShow.TabIndex = 0;
            this.chk_PassShow.Text = "Show Password";
            this.chk_PassShow.UseVisualStyleBackColor = true;
            this.chk_PassShow.CheckedChanged += new System.EventHandler(this.chk_PassShow_CheckedChanged);
            // 
            // chk_KeepMeSignedIn
            // 
            this.chk_KeepMeSignedIn.AutoSize = true;
            this.chk_KeepMeSignedIn.Location = new System.Drawing.Point(453, 82);
            this.chk_KeepMeSignedIn.Name = "chk_KeepMeSignedIn";
            this.chk_KeepMeSignedIn.Size = new System.Drawing.Size(192, 28);
            this.chk_KeepMeSignedIn.TabIndex = 0;
            this.chk_KeepMeSignedIn.Text = "Keep me signed in";
            this.chk_KeepMeSignedIn.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(173, 165);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(246, 32);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Password_Validating);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(173, 108);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(246, 32);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            this.txt_Username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Username_Validating);
            // 
            // txt_Emp
            // 
            this.txt_Emp.Location = new System.Drawing.Point(173, 49);
            this.txt_Emp.Name = "txt_Emp";
            this.txt_Emp.Size = new System.Drawing.Size(246, 32);
            this.txt_Emp.TabIndex = 1;
            this.txt_Emp.TextChanged += new System.EventHandler(this.txt_Emp_TextChanged);
            this.txt_Emp.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Emp_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee:";
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::Module_1.Properties.Resources.login_box_line;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(230, 378);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(130, 40);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btn_Exit.Image = global::Module_1.Properties.Resources.login_box_line;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(409, 378);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Don\'t have an account?";
            // 
            // link_CreateAcc
            // 
            this.link_CreateAcc.AutoSize = true;
            this.link_CreateAcc.Location = new System.Drawing.Point(438, 434);
            this.link_CreateAcc.Name = "link_CreateAcc";
            this.link_CreateAcc.Size = new System.Drawing.Size(101, 24);
            this.link_CreateAcc.TabIndex = 6;
            this.link_CreateAcc.TabStop = true;
            this.link_CreateAcc.Text = "Create one";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 489);
            this.Controls.Add(this.link_CreateAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.gr_Login);
            this.Controls.Add(this.pic_Logo);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.Text = "Seoul Stay - Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.gr_Login.ResumeLayout(false);
            this.gr_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.GroupBox gr_Login;
        private System.Windows.Forms.CheckBox chk_PassShow;
        private System.Windows.Forms.CheckBox chk_KeepMeSignedIn;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Emp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_CreateAcc;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}


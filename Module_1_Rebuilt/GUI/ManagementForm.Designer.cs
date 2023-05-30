namespace Module_1_Rebuilt.GUI
{
    partial class ManagementForm
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
            this.accessTabCtr = new System.Windows.Forms.TabControl();
            this.tab_Traveler = new System.Windows.Forms.TabPage();
            this.dgv_Traveler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.tab_Emp = new System.Windows.Forms.TabPage();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_resultTravelCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_resultEmpCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_AddListing = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accessTabCtr.SuspendLayout();
            this.tab_Traveler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Traveler)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accessTabCtr
            // 
            this.accessTabCtr.Controls.Add(this.tab_Traveler);
            this.accessTabCtr.Controls.Add(this.tab_Emp);
            this.accessTabCtr.Location = new System.Drawing.Point(12, 161);
            this.accessTabCtr.Name = "accessTabCtr";
            this.accessTabCtr.SelectedIndex = 0;
            this.accessTabCtr.Size = new System.Drawing.Size(858, 580);
            this.accessTabCtr.TabIndex = 1;
            // 
            // tab_Traveler
            // 
            this.tab_Traveler.Controls.Add(this.panel1);
            this.tab_Traveler.Controls.Add(this.dgv_Traveler);
            this.tab_Traveler.Controls.Add(this.panel2);
            this.tab_Traveler.Location = new System.Drawing.Point(4, 29);
            this.tab_Traveler.Name = "tab_Traveler";
            this.tab_Traveler.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Traveler.Size = new System.Drawing.Size(850, 547);
            this.tab_Traveler.TabIndex = 0;
            this.tab_Traveler.Text = "I\'m Traveler";
            this.tab_Traveler.UseVisualStyleBackColor = true;
            // 
            // dgv_Traveler
            // 
            this.dgv_Traveler.AllowUserToAddRows = false;
            this.dgv_Traveler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Traveler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Traveler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Traveler.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Traveler.Location = new System.Drawing.Point(4, 62);
            this.dgv_Traveler.Name = "dgv_Traveler";
            this.dgv_Traveler.ReadOnly = true;
            this.dgv_Traveler.RowHeadersVisible = false;
            this.dgv_Traveler.RowHeadersWidth = 51;
            this.dgv_Traveler.RowTemplate.Height = 24;
            this.dgv_Traveler.Size = new System.Drawing.Size(838, 440);
            this.dgv_Traveler.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 50);
            this.panel2.TabIndex = 1;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Location = new System.Drawing.Point(47, 8);
            this.txt_Search.MaximumSize = new System.Drawing.Size(800, 50);
            this.txt_Search.MinimumSize = new System.Drawing.Size(480, 32);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(640, 28);
            this.txt_Search.TabIndex = 0;
            // 
            // tab_Emp
            // 
            this.tab_Emp.Controls.Add(this.btn_AddListing);
            this.tab_Emp.Controls.Add(this.panel3);
            this.tab_Emp.Controls.Add(this.dgv_Employee);
            this.tab_Emp.Location = new System.Drawing.Point(4, 29);
            this.tab_Emp.Name = "tab_Emp";
            this.tab_Emp.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Emp.Size = new System.Drawing.Size(850, 547);
            this.tab_Emp.TabIndex = 1;
            this.tab_Emp.Text = "I\'m Owner / Manager";
            this.tab_Emp.UseVisualStyleBackColor = true;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Employee.Location = new System.Drawing.Point(6, 41);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowHeadersVisible = false;
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(838, 461);
            this.dgv_Employee.TabIndex = 3;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(666, 144);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(90, 35);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btn_Exit.Location = new System.Drawing.Point(776, 144);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 35);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_resultTravelCount);
            this.panel1.Location = new System.Drawing.Point(3, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 33);
            this.panel1.TabIndex = 10;
            // 
            // lbl_resultTravelCount
            // 
            this.lbl_resultTravelCount.AutoSize = true;
            this.lbl_resultTravelCount.Location = new System.Drawing.Point(3, 7);
            this.lbl_resultTravelCount.Name = "lbl_resultTravelCount";
            this.lbl_resultTravelCount.Size = new System.Drawing.Size(117, 20);
            this.lbl_resultTravelCount.TabIndex = 0;
            this.lbl_resultTravelCount.Text = "0 item(s) found.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_resultEmpCount);
            this.panel3.Location = new System.Drawing.Point(6, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 33);
            this.panel3.TabIndex = 11;
            // 
            // lbl_resultEmpCount
            // 
            this.lbl_resultEmpCount.AutoSize = true;
            this.lbl_resultEmpCount.Location = new System.Drawing.Point(3, 7);
            this.lbl_resultEmpCount.Name = "lbl_resultEmpCount";
            this.lbl_resultEmpCount.Size = new System.Drawing.Size(117, 20);
            this.lbl_resultEmpCount.TabIndex = 0;
            this.lbl_resultEmpCount.Text = "0 item(s) found.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Module_1_Rebuilt.Properties.Resources.search_2_line;
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_AddListing
            // 
            this.btn_AddListing.Image = global::Module_1_Rebuilt.Properties.Resources.add_box_line;
            this.btn_AddListing.Location = new System.Drawing.Point(6, 5);
            this.btn_AddListing.Name = "btn_AddListing";
            this.btn_AddListing.Size = new System.Drawing.Size(152, 30);
            this.btn_AddListing.TabIndex = 12;
            this.btn_AddListing.Text = "Add Listing";
            this.btn_AddListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddListing.UseVisualStyleBackColor = true;
            this.btn_AddListing.Click += new System.EventHandler(this.btn_AddListing_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Module_1_Rebuilt.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.pictureBox1.Location = new System.Drawing.Point(136, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Size = new System.Drawing.Size(600, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.accessTabCtr);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Open Sans", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagementForm";
            this.Text = "SeoulStay - Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.accessTabCtr.ResumeLayout(false);
            this.tab_Traveler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Traveler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_Emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl accessTabCtr;
        private System.Windows.Forms.TabPage tab_Traveler;
        private System.Windows.Forms.TabPage tab_Emp;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_resultTravelCount;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgv_Traveler;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_resultEmpCount;
        private System.Windows.Forms.Button btn_AddListing;
    }
}
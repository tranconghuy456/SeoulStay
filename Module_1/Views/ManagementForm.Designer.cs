namespace Module_1.Views
{
    partial class frm_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Management));
            this.tabCtr_Client = new System.Windows.Forms.TabControl();
            this.tabpg_Traveler = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_travel = new System.Windows.Forms.DataGridView();
            this.tabpg_Owner = new System.Windows.Forms.TabPage();
            this.dgv_Emp = new System.Windows.Forms.DataGridView();
            this.btn_AddListing = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.tabCtr_Client.SuspendLayout();
            this.tabpg_Traveler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_travel)).BeginInit();
            this.tabpg_Owner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtr_Client
            // 
            this.tabCtr_Client.Controls.Add(this.tabpg_Traveler);
            this.tabCtr_Client.Controls.Add(this.tabpg_Owner);
            this.tabCtr_Client.Location = new System.Drawing.Point(12, 149);
            this.tabCtr_Client.Name = "tabCtr_Client";
            this.tabCtr_Client.SelectedIndex = 0;
            this.tabCtr_Client.Size = new System.Drawing.Size(854, 480);
            this.tabCtr_Client.TabIndex = 2;
            // 
            // tabpg_Traveler
            // 
            this.tabpg_Traveler.Controls.Add(this.panel1);
            this.tabpg_Traveler.Controls.Add(this.dgv_travel);
            this.tabpg_Traveler.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Traveler.Name = "tabpg_Traveler";
            this.tabpg_Traveler.Padding = new System.Windows.Forms.Padding(6);
            this.tabpg_Traveler.Size = new System.Drawing.Size(846, 443);
            this.tabpg_Traveler.TabIndex = 0;
            this.tabpg_Traveler.Text = "I\'m Traveler";
            this.tabpg_Traveler.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Location = new System.Drawing.Point(18, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 40);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Module_1.Properties.Resources.search_2_line;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Search.Location = new System.Drawing.Point(44, 3);
            this.txt_Search.MaximumSize = new System.Drawing.Size(1000, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(655, 32);
            this.txt_Search.TabIndex = 0;
            // 
            // dgv_travel
            // 
            this.dgv_travel.AllowUserToAddRows = false;
            this.dgv_travel.AllowUserToDeleteRows = false;
            this.dgv_travel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_travel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_travel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_travel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_travel.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_travel.Location = new System.Drawing.Point(18, 55);
            this.dgv_travel.MultiSelect = false;
            this.dgv_travel.Name = "dgv_travel";
            this.dgv_travel.ReadOnly = true;
            this.dgv_travel.RowTemplate.Height = 28;
            this.dgv_travel.Size = new System.Drawing.Size(811, 379);
            this.dgv_travel.TabIndex = 1;
            // 
            // tabpg_Owner
            // 
            this.tabpg_Owner.Controls.Add(this.dgv_Emp);
            this.tabpg_Owner.Controls.Add(this.btn_AddListing);
            this.tabpg_Owner.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Owner.Name = "tabpg_Owner";
            this.tabpg_Owner.Padding = new System.Windows.Forms.Padding(6);
            this.tabpg_Owner.Size = new System.Drawing.Size(846, 443);
            this.tabpg_Owner.TabIndex = 1;
            this.tabpg_Owner.Text = "I\'m Owner / Manager";
            this.tabpg_Owner.UseVisualStyleBackColor = true;
            // 
            // dgv_Emp
            // 
            this.dgv_Emp.AllowUserToAddRows = false;
            this.dgv_Emp.AllowUserToDeleteRows = false;
            this.dgv_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Emp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Emp.Location = new System.Drawing.Point(17, 65);
            this.dgv_Emp.MultiSelect = false;
            this.dgv_Emp.Name = "dgv_Emp";
            this.dgv_Emp.ReadOnly = true;
            this.dgv_Emp.RowTemplate.Height = 28;
            this.dgv_Emp.Size = new System.Drawing.Size(811, 369);
            this.dgv_Emp.TabIndex = 2;
            this.dgv_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Emp_CellContentClick);
            // 
            // btn_AddListing
            // 
            this.btn_AddListing.Image = global::Module_1.Properties.Resources.add_box_line;
            this.btn_AddListing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddListing.Location = new System.Drawing.Point(17, 9);
            this.btn_AddListing.Name = "btn_AddListing";
            this.btn_AddListing.Size = new System.Drawing.Size(160, 50);
            this.btn_AddListing.TabIndex = 0;
            this.btn_AddListing.Text = "Add Listing";
            this.btn_AddListing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddListing.UseVisualStyleBackColor = true;
            this.btn_AddListing.Click += new System.EventHandler(this.btn_AddListing_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(636, 130);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(100, 40);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(762, 130);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(155, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(550, 100);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 1;
            this.pic_Logo.TabStop = false;
            // 
            // frm_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.tabCtr_Client);
            this.Controls.Add(this.pic_Logo);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Management";
            this.Text = "Seoul Stay - Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Management_FormClosing);
            this.Load += new System.EventHandler(this.frm_Management_Load);
            this.tabCtr_Client.ResumeLayout(false);
            this.tabpg_Traveler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_travel)).EndInit();
            this.tabpg_Owner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.TabControl tabCtr_Client;
        private System.Windows.Forms.TabPage tabpg_Traveler;
        private System.Windows.Forms.TabPage tabpg_Owner;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgv_travel;
        private System.Windows.Forms.DataGridView dgv_Emp;
        private System.Windows.Forms.Button btn_AddListing;
    }
}
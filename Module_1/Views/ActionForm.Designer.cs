namespace Module_1.Views
{
    partial class frm_Action
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
            this.dgv_Amenity = new System.Windows.Forms.DataGridView();
            this.dgv_Attraction = new System.Windows.Forms.DataGridView();
            this.tabCtr_Action = new System.Windows.Forms.TabControl();
            this.tabpg_Details = new System.Windows.Forms.TabPage();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_HostRules = new System.Windows.Forms.TextBox();
            this.rtxt_Des = new System.Windows.Forms.RichTextBox();
            this.txt_ExactAddr = new System.Windows.Forms.TextBox();
            this.txt_ApproAddr = new System.Windows.Forms.TextBox();
            this.nbric_NoBathrooms = new System.Windows.Forms.NumericUpDown();
            this.nbric_NoBedrooms = new System.Windows.Forms.NumericUpDown();
            this.nbric_NoBeds = new System.Windows.Forms.NumericUpDown();
            this.nbric_ReserMax = new System.Windows.Forms.NumericUpDown();
            this.nbric_ReserMin = new System.Windows.Forms.NumericUpDown();
            this.nbric_Capacity = new System.Windows.Forms.NumericUpDown();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpg_Amenities = new System.Windows.Forms.TabPage();
            this.btn_Cancel_1 = new System.Windows.Forms.Button();
            this.btn_Next_1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabpg_DTA = new System.Windows.Forms.TabPage();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Amenity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attraction)).BeginInit();
            this.tabCtr_Action.SuspendLayout();
            this.tabpg_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_ReserMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_ReserMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_Capacity)).BeginInit();
            this.tabpg_Amenities.SuspendLayout();
            this.tabpg_DTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Amenity
            // 
            this.dgv_Amenity.AllowUserToAddRows = false;
            this.dgv_Amenity.AllowUserToDeleteRows = false;
            this.dgv_Amenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Amenity.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Amenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Amenity.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Amenity.Location = new System.Drawing.Point(47, 62);
            this.dgv_Amenity.Name = "dgv_Amenity";
            this.dgv_Amenity.RowTemplate.Height = 28;
            this.dgv_Amenity.Size = new System.Drawing.Size(550, 415);
            this.dgv_Amenity.TabIndex = 1;
            this.dgv_Amenity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Amenity_CellContentClick);
            // 
            // dgv_Attraction
            // 
            this.dgv_Attraction.AllowUserToAddRows = false;
            this.dgv_Attraction.AllowUserToDeleteRows = false;
            this.dgv_Attraction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Attraction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Attraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Attraction.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Attraction.Location = new System.Drawing.Point(19, 68);
            this.dgv_Attraction.Name = "dgv_Attraction";
            this.dgv_Attraction.RowTemplate.Height = 28;
            this.dgv_Attraction.Size = new System.Drawing.Size(862, 413);
            this.dgv_Attraction.TabIndex = 2;
            // 
            // tabCtr_Action
            // 
            this.tabCtr_Action.Controls.Add(this.tabpg_Details);
            this.tabCtr_Action.Controls.Add(this.tabpg_Amenities);
            this.tabCtr_Action.Controls.Add(this.tabpg_DTA);
            this.tabCtr_Action.Location = new System.Drawing.Point(12, 22);
            this.tabCtr_Action.Name = "tabCtr_Action";
            this.tabCtr_Action.SelectedIndex = 0;
            this.tabCtr_Action.Size = new System.Drawing.Size(934, 600);
            this.tabCtr_Action.TabIndex = 0;
            // 
            // tabpg_Details
            // 
            this.tabpg_Details.Controls.Add(this.btn_Cancel);
            this.tabpg_Details.Controls.Add(this.btn_Next);
            this.tabpg_Details.Controls.Add(this.txt_HostRules);
            this.tabpg_Details.Controls.Add(this.rtxt_Des);
            this.tabpg_Details.Controls.Add(this.txt_ExactAddr);
            this.tabpg_Details.Controls.Add(this.txt_ApproAddr);
            this.tabpg_Details.Controls.Add(this.nbric_NoBathrooms);
            this.tabpg_Details.Controls.Add(this.nbric_NoBedrooms);
            this.tabpg_Details.Controls.Add(this.nbric_NoBeds);
            this.tabpg_Details.Controls.Add(this.nbric_ReserMax);
            this.tabpg_Details.Controls.Add(this.nbric_ReserMin);
            this.tabpg_Details.Controls.Add(this.nbric_Capacity);
            this.tabpg_Details.Controls.Add(this.txt_Title);
            this.tabpg_Details.Controls.Add(this.cb_Type);
            this.tabpg_Details.Controls.Add(this.label6);
            this.tabpg_Details.Controls.Add(this.label5);
            this.tabpg_Details.Controls.Add(this.label4);
            this.tabpg_Details.Controls.Add(this.label2);
            this.tabpg_Details.Controls.Add(this.label13);
            this.tabpg_Details.Controls.Add(this.label12);
            this.tabpg_Details.Controls.Add(this.label11);
            this.tabpg_Details.Controls.Add(this.label10);
            this.tabpg_Details.Controls.Add(this.label9);
            this.tabpg_Details.Controls.Add(this.label8);
            this.tabpg_Details.Controls.Add(this.label7);
            this.tabpg_Details.Controls.Add(this.label3);
            this.tabpg_Details.Controls.Add(this.label1);
            this.tabpg_Details.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Details.Name = "tabpg_Details";
            this.tabpg_Details.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_Details.Size = new System.Drawing.Size(926, 563);
            this.tabpg_Details.TabIndex = 0;
            this.tabpg_Details.Text = "Listing Details";
            this.tabpg_Details.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btn_Cancel.Location = new System.Drawing.Point(740, 504);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(572, 504);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(150, 40);
            this.btn_Next.TabIndex = 13;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // txt_HostRules
            // 
            this.txt_HostRules.Location = new System.Drawing.Point(222, 368);
            this.txt_HostRules.MaximumSize = new System.Drawing.Size(1000, 100);
            this.txt_HostRules.MinimumSize = new System.Drawing.Size(650, 45);
            this.txt_HostRules.Name = "txt_HostRules";
            this.txt_HostRules.Size = new System.Drawing.Size(668, 32);
            this.txt_HostRules.TabIndex = 10;
            this.txt_HostRules.Validating += new System.ComponentModel.CancelEventHandler(this.txt_HostRules_Validating);
            // 
            // rtxt_Des
            // 
            this.rtxt_Des.Location = new System.Drawing.Point(222, 229);
            this.rtxt_Des.Name = "rtxt_Des";
            this.rtxt_Des.Size = new System.Drawing.Size(668, 126);
            this.rtxt_Des.TabIndex = 9;
            this.rtxt_Des.Text = "";
            this.rtxt_Des.Validating += new System.ComponentModel.CancelEventHandler(this.rtxt_Des_Validating);
            // 
            // txt_ExactAddr
            // 
            this.txt_ExactAddr.Location = new System.Drawing.Point(222, 173);
            this.txt_ExactAddr.MaximumSize = new System.Drawing.Size(1000, 100);
            this.txt_ExactAddr.MinimumSize = new System.Drawing.Size(650, 45);
            this.txt_ExactAddr.Name = "txt_ExactAddr";
            this.txt_ExactAddr.Size = new System.Drawing.Size(668, 32);
            this.txt_ExactAddr.TabIndex = 8;
            this.txt_ExactAddr.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ExactAddr_Validating);
            // 
            // txt_ApproAddr
            // 
            this.txt_ApproAddr.Location = new System.Drawing.Point(222, 125);
            this.txt_ApproAddr.Name = "txt_ApproAddr";
            this.txt_ApproAddr.Size = new System.Drawing.Size(668, 32);
            this.txt_ApproAddr.TabIndex = 7;
            this.txt_ApproAddr.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ApproAddr_Validating);
            // 
            // nbric_NoBathrooms
            // 
            this.nbric_NoBathrooms.Location = new System.Drawing.Point(840, 67);
            this.nbric_NoBathrooms.Name = "nbric_NoBathrooms";
            this.nbric_NoBathrooms.Size = new System.Drawing.Size(50, 32);
            this.nbric_NoBathrooms.TabIndex = 6;
            this.nbric_NoBathrooms.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_NoBathrooms_Validating);
            // 
            // nbric_NoBedrooms
            // 
            this.nbric_NoBedrooms.Location = new System.Drawing.Point(572, 67);
            this.nbric_NoBedrooms.Name = "nbric_NoBedrooms";
            this.nbric_NoBedrooms.Size = new System.Drawing.Size(50, 32);
            this.nbric_NoBedrooms.TabIndex = 5;
            this.nbric_NoBedrooms.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_NoBedrooms_Validating);
            // 
            // nbric_NoBeds
            // 
            this.nbric_NoBeds.Location = new System.Drawing.Point(314, 67);
            this.nbric_NoBeds.Name = "nbric_NoBeds";
            this.nbric_NoBeds.Size = new System.Drawing.Size(50, 32);
            this.nbric_NoBeds.TabIndex = 4;
            this.nbric_NoBeds.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_NoBeds_Validating);
            // 
            // nbric_ReserMax
            // 
            this.nbric_ReserMax.Location = new System.Drawing.Point(593, 441);
            this.nbric_ReserMax.Name = "nbric_ReserMax";
            this.nbric_ReserMax.Size = new System.Drawing.Size(50, 32);
            this.nbric_ReserMax.TabIndex = 12;
            this.nbric_ReserMax.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_ReserMax_Validating);
            // 
            // nbric_ReserMin
            // 
            this.nbric_ReserMin.Location = new System.Drawing.Point(383, 441);
            this.nbric_ReserMin.Name = "nbric_ReserMin";
            this.nbric_ReserMin.Size = new System.Drawing.Size(50, 32);
            this.nbric_ReserMin.TabIndex = 11;
            this.nbric_ReserMin.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_ReserMin_Validating);
            // 
            // nbric_Capacity
            // 
            this.nbric_Capacity.Location = new System.Drawing.Point(98, 67);
            this.nbric_Capacity.Name = "nbric_Capacity";
            this.nbric_Capacity.Size = new System.Drawing.Size(50, 32);
            this.nbric_Capacity.TabIndex = 3;
            this.nbric_Capacity.Validating += new System.ComponentModel.CancelEventHandler(this.nbric_Capacity_Validating);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(505, 12);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(385, 32);
            this.txt_Title.TabIndex = 2;
            this.txt_Title.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Title_Validating);
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(67, 12);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(307, 32);
            this.cb_Type.TabIndex = 1;
            this.cb_Type.Text = "--- Select Serivce Type ---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of Bathrooms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Bedrooms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Beds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(493, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Maximum:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Minimum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reservation Time (Nights):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Host Rules:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exact Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Approximate Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // tabpg_Amenities
            // 
            this.tabpg_Amenities.Controls.Add(this.btn_Cancel_1);
            this.tabpg_Amenities.Controls.Add(this.btn_Next_1);
            this.tabpg_Amenities.Controls.Add(this.dgv_Amenity);
            this.tabpg_Amenities.Controls.Add(this.label14);
            this.tabpg_Amenities.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Amenities.Name = "tabpg_Amenities";
            this.tabpg_Amenities.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_Amenities.Size = new System.Drawing.Size(926, 563);
            this.tabpg_Amenities.TabIndex = 1;
            this.tabpg_Amenities.Text = "Amenities";
            this.tabpg_Amenities.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel_1
            // 
            this.btn_Cancel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btn_Cancel_1.Location = new System.Drawing.Point(740, 504);
            this.btn_Cancel_1.Name = "btn_Cancel_1";
            this.btn_Cancel_1.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancel_1.TabIndex = 6;
            this.btn_Cancel_1.Text = "Cancel";
            this.btn_Cancel_1.UseVisualStyleBackColor = true;
            // 
            // btn_Next_1
            // 
            this.btn_Next_1.Location = new System.Drawing.Point(572, 504);
            this.btn_Next_1.Name = "btn_Next_1";
            this.btn_Next_1.Size = new System.Drawing.Size(150, 40);
            this.btn_Next_1.TabIndex = 5;
            this.btn_Next_1.Text = "Next";
            this.btn_Next_1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Choose Available Amenities:";
            // 
            // tabpg_DTA
            // 
            this.tabpg_DTA.Controls.Add(this.btn_Finish);
            this.tabpg_DTA.Controls.Add(this.dgv_Attraction);
            this.tabpg_DTA.Controls.Add(this.label15);
            this.tabpg_DTA.Location = new System.Drawing.Point(4, 33);
            this.tabpg_DTA.Name = "tabpg_DTA";
            this.tabpg_DTA.Size = new System.Drawing.Size(926, 563);
            this.tabpg_DTA.TabIndex = 2;
            this.tabpg_DTA.Text = "Distance to Attraction";
            this.tabpg_DTA.UseVisualStyleBackColor = true;
            // 
            // btn_Finish
            // 
            this.btn_Finish.ForeColor = System.Drawing.Color.Black;
            this.btn_Finish.Location = new System.Drawing.Point(731, 502);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(150, 40);
            this.btn_Finish.TabIndex = 4;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(735, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Specify the distance from each close by attraction and the time it takes to get t" +
    "o them:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(948, 634);
            this.Controls.Add(this.tabCtr_Action);
            this.Font = new System.Drawing.Font("Open Sans", 9F);
            this.Name = "frm_Action";
            this.Text = "Seoul Stay - Add / Edit Listing";
            this.Load += new System.EventHandler(this.frm_Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Amenity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attraction)).EndInit();
            this.tabCtr_Action.ResumeLayout(false);
            this.tabpg_Details.ResumeLayout(false);
            this.tabpg_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_NoBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_ReserMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_ReserMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_Capacity)).EndInit();
            this.tabpg_Amenities.ResumeLayout(false);
            this.tabpg_Amenities.PerformLayout();
            this.tabpg_DTA.ResumeLayout(false);
            this.tabpg_DTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtr_Action;
        private System.Windows.Forms.TabPage tabpg_Details;
        private System.Windows.Forms.TabPage tabpg_Amenities;
        private System.Windows.Forms.TabPage tabpg_DTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.NumericUpDown nbric_NoBeds;
        private System.Windows.Forms.NumericUpDown nbric_Capacity;
        private System.Windows.Forms.NumericUpDown nbric_NoBathrooms;
        private System.Windows.Forms.NumericUpDown nbric_NoBedrooms;
        private System.Windows.Forms.TextBox txt_ApproAddr;
        private System.Windows.Forms.TextBox txt_ExactAddr;
        private System.Windows.Forms.RichTextBox rtxt_Des;
        private System.Windows.Forms.TextBox txt_HostRules;
        private System.Windows.Forms.NumericUpDown nbric_ReserMax;
        private System.Windows.Forms.NumericUpDown nbric_ReserMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Cancel_1;
        private System.Windows.Forms.Button btn_Next_1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dgv_Amenity;
        private System.Windows.Forms.DataGridView dgv_Attraction;
    }
}
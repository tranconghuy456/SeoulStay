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
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.tabCtr_Client = new System.Windows.Forms.TabControl();
            this.tabpg_Traveler = new System.Windows.Forms.TabPage();
            this.tabpg_Owner = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.tabCtr_Client.SuspendLayout();
            this.SuspendLayout();
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
            // tabCtr_Client
            // 
            this.tabCtr_Client.Controls.Add(this.tabpg_Traveler);
            this.tabCtr_Client.Controls.Add(this.tabpg_Owner);
            this.tabCtr_Client.Location = new System.Drawing.Point(12, 149);
            this.tabCtr_Client.Name = "tabCtr_Client";
            this.tabCtr_Client.SelectedIndex = 0;
            this.tabCtr_Client.Size = new System.Drawing.Size(854, 383);
            this.tabCtr_Client.TabIndex = 2;
            // 
            // tabpg_Traveler
            // 
            this.tabpg_Traveler.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Traveler.Name = "tabpg_Traveler";
            this.tabpg_Traveler.Padding = new System.Windows.Forms.Padding(6);
            this.tabpg_Traveler.Size = new System.Drawing.Size(846, 346);
            this.tabpg_Traveler.TabIndex = 0;
            this.tabpg_Traveler.Text = "I\'m Traveler";
            this.tabpg_Traveler.UseVisualStyleBackColor = true;
            // 
            // tabpg_Owner
            // 
            this.tabpg_Owner.Location = new System.Drawing.Point(4, 33);
            this.tabpg_Owner.Name = "tabpg_Owner";
            this.tabpg_Owner.Padding = new System.Windows.Forms.Padding(6);
            this.tabpg_Owner.Size = new System.Drawing.Size(846, 346);
            this.tabpg_Owner.TabIndex = 1;
            this.tabpg_Owner.Text = "I\'m Owner / Manager";
            this.tabpg_Owner.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCtr_Client);
            this.Controls.Add(this.pic_Logo);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Management";
            this.Text = "Seoul Stay - Management";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.tabCtr_Client.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.TabControl tabCtr_Client;
        private System.Windows.Forms.TabPage tabpg_Traveler;
        private System.Windows.Forms.TabPage tabpg_Owner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
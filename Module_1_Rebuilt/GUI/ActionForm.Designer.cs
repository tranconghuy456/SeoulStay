namespace Module_1_Rebuilt.GUI
{
    partial class ActionForm
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
            this.tabCtr_Action = new System.Windows.Forms.TabControl();
            this.tabpg_ListingDetails = new System.Windows.Forms.TabPage();
            this.tabpg_Amenities = new System.Windows.Forms.TabPage();
            this.tabpg_Distance = new System.Windows.Forms.TabPage();
            this.tabCtr_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtr_Action
            // 
            this.tabCtr_Action.Controls.Add(this.tabpg_ListingDetails);
            this.tabCtr_Action.Controls.Add(this.tabpg_Amenities);
            this.tabCtr_Action.Controls.Add(this.tabpg_Distance);
            this.tabCtr_Action.Location = new System.Drawing.Point(12, 28);
            this.tabCtr_Action.Name = "tabCtr_Action";
            this.tabCtr_Action.SelectedIndex = 0;
            this.tabCtr_Action.Size = new System.Drawing.Size(858, 513);
            this.tabCtr_Action.TabIndex = 0;
            // 
            // tabpg_ListingDetails
            // 
            this.tabpg_ListingDetails.Location = new System.Drawing.Point(4, 29);
            this.tabpg_ListingDetails.Name = "tabpg_ListingDetails";
            this.tabpg_ListingDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_ListingDetails.Size = new System.Drawing.Size(850, 480);
            this.tabpg_ListingDetails.TabIndex = 0;
            this.tabpg_ListingDetails.Text = "Listing Details";
            this.tabpg_ListingDetails.UseVisualStyleBackColor = true;
            // 
            // tabpg_Amenities
            // 
            this.tabpg_Amenities.Location = new System.Drawing.Point(4, 29);
            this.tabpg_Amenities.Name = "tabpg_Amenities";
            this.tabpg_Amenities.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_Amenities.Size = new System.Drawing.Size(850, 480);
            this.tabpg_Amenities.TabIndex = 1;
            this.tabpg_Amenities.Text = "Amenities";
            this.tabpg_Amenities.UseVisualStyleBackColor = true;
            // 
            // tabpg_Distance
            // 
            this.tabpg_Distance.Location = new System.Drawing.Point(4, 29);
            this.tabpg_Distance.Name = "tabpg_Distance";
            this.tabpg_Distance.Size = new System.Drawing.Size(850, 480);
            this.tabpg_Distance.TabIndex = 2;
            this.tabpg_Distance.Text = "Distance to Attraction";
            this.tabpg_Distance.UseVisualStyleBackColor = true;
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tabCtr_Action);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActionForm";
            this.Text = "SeoulStay - Add / Edit Listing";
            this.tabCtr_Action.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtr_Action;
        private System.Windows.Forms.TabPage tabpg_ListingDetails;
        private System.Windows.Forms.TabPage tabpg_Amenities;
        private System.Windows.Forms.TabPage tabpg_Distance;
    }
}
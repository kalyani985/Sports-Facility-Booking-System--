namespace SA41Team02B
{
    partial class Form_FacilityForm
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
            this.LB_FacilityName = new System.Windows.Forms.Label();
            this.BT_Search = new System.Windows.Forms.Button();
            this.GB_Facility = new System.Windows.Forms.GroupBox();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_UpdateFacility = new System.Windows.Forms.Button();
            this.BT_CreateFacility = new System.Windows.Forms.Button();
            this.TB_Fees = new System.Windows.Forms.TextBox();
            this.LB_Fees = new System.Windows.Forms.Label();
            this.TB_MaxPax = new System.Windows.Forms.TextBox();
            this.LB_MaxPax = new System.Windows.Forms.Label();
            this.TB_FacilityName2 = new System.Windows.Forms.TextBox();
            this.LB_FacilityName2 = new System.Windows.Forms.Label();
            this.TB_FacilityID = new System.Windows.Forms.TextBox();
            this.LB_FacilityID = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CMB_FacilityName = new System.Windows.Forms.ComboBox();
            this.availability1TableAdapter1 = new SA41Team02B.BookingSystemDataSetTableAdapters.Availability1TableAdapter();
            this.GB_Facility.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_FacilityName
            // 
            this.LB_FacilityName.AutoSize = true;
            this.LB_FacilityName.Location = new System.Drawing.Point(177, 78);
            this.LB_FacilityName.Name = "LB_FacilityName";
            this.LB_FacilityName.Size = new System.Drawing.Size(125, 13);
            this.LB_FacilityName.TabIndex = 0;
            this.LB_FacilityName.Text = "Search By Facility Name:";
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(580, 71);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 2;
            this.BT_Search.Text = "Enter";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // GB_Facility
            // 
            this.GB_Facility.Controls.Add(this.BT_Delete);
            this.GB_Facility.Controls.Add(this.BT_UpdateFacility);
            this.GB_Facility.Controls.Add(this.BT_CreateFacility);
            this.GB_Facility.Controls.Add(this.TB_Fees);
            this.GB_Facility.Controls.Add(this.LB_Fees);
            this.GB_Facility.Controls.Add(this.TB_MaxPax);
            this.GB_Facility.Controls.Add(this.LB_MaxPax);
            this.GB_Facility.Controls.Add(this.TB_FacilityName2);
            this.GB_Facility.Controls.Add(this.LB_FacilityName2);
            this.GB_Facility.Controls.Add(this.TB_FacilityID);
            this.GB_Facility.Controls.Add(this.LB_FacilityID);
            this.GB_Facility.Location = new System.Drawing.Point(59, 124);
            this.GB_Facility.Name = "GB_Facility";
            this.GB_Facility.Size = new System.Drawing.Size(721, 322);
            this.GB_Facility.TabIndex = 3;
            this.GB_Facility.TabStop = false;
            this.GB_Facility.Text = "Facilities";
            this.GB_Facility.Enter += new System.EventHandler(this.GB_Facility_Enter);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(483, 238);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(113, 23);
            this.BT_Delete.TabIndex = 6;
            this.BT_Delete.Text = "Delete Facility";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_UpdateFacility
            // 
            this.BT_UpdateFacility.Location = new System.Drawing.Point(279, 238);
            this.BT_UpdateFacility.Name = "BT_UpdateFacility";
            this.BT_UpdateFacility.Size = new System.Drawing.Size(123, 23);
            this.BT_UpdateFacility.TabIndex = 13;
            this.BT_UpdateFacility.Text = "Update Facility";
            this.BT_UpdateFacility.UseVisualStyleBackColor = true;
            this.BT_UpdateFacility.Click += new System.EventHandler(this.BT_UpdateFacility_Click);
            // 
            // BT_CreateFacility
            // 
            this.BT_CreateFacility.Location = new System.Drawing.Point(82, 238);
            this.BT_CreateFacility.Name = "BT_CreateFacility";
            this.BT_CreateFacility.Size = new System.Drawing.Size(116, 23);
            this.BT_CreateFacility.TabIndex = 12;
            this.BT_CreateFacility.Text = "Create Facility";
            this.BT_CreateFacility.UseVisualStyleBackColor = true;
            this.BT_CreateFacility.Click += new System.EventHandler(this.BT_CreateFacility_Click);
            // 
            // TB_Fees
            // 
            this.TB_Fees.Location = new System.Drawing.Point(322, 165);
            this.TB_Fees.Name = "TB_Fees";
            this.TB_Fees.Size = new System.Drawing.Size(70, 20);
            this.TB_Fees.TabIndex = 11;
            // 
            // LB_Fees
            // 
            this.LB_Fees.AutoSize = true;
            this.LB_Fees.Location = new System.Drawing.Point(267, 166);
            this.LB_Fees.Name = "LB_Fees";
            this.LB_Fees.Size = new System.Drawing.Size(33, 13);
            this.LB_Fees.TabIndex = 10;
            this.LB_Fees.Text = "Fees:";
            // 
            // TB_MaxPax
            // 
            this.TB_MaxPax.Location = new System.Drawing.Point(322, 128);
            this.TB_MaxPax.Name = "TB_MaxPax";
            this.TB_MaxPax.Size = new System.Drawing.Size(49, 20);
            this.TB_MaxPax.TabIndex = 9;
            // 
            // LB_MaxPax
            // 
            this.LB_MaxPax.AutoSize = true;
            this.LB_MaxPax.Location = new System.Drawing.Point(249, 129);
            this.LB_MaxPax.Name = "LB_MaxPax";
            this.LB_MaxPax.Size = new System.Drawing.Size(51, 13);
            this.LB_MaxPax.TabIndex = 8;
            this.LB_MaxPax.Text = "Max Pax:";
            // 
            // TB_FacilityName2
            // 
            this.TB_FacilityName2.Location = new System.Drawing.Point(322, 92);
            this.TB_FacilityName2.Name = "TB_FacilityName2";
            this.TB_FacilityName2.Size = new System.Drawing.Size(180, 20);
            this.TB_FacilityName2.TabIndex = 7;
            // 
            // LB_FacilityName2
            // 
            this.LB_FacilityName2.AutoSize = true;
            this.LB_FacilityName2.Location = new System.Drawing.Point(228, 92);
            this.LB_FacilityName2.Name = "LB_FacilityName2";
            this.LB_FacilityName2.Size = new System.Drawing.Size(73, 13);
            this.LB_FacilityName2.TabIndex = 6;
            this.LB_FacilityName2.Text = "Facility Name:";
            // 
            // TB_FacilityID
            // 
            this.TB_FacilityID.Location = new System.Drawing.Point(322, 54);
            this.TB_FacilityID.Name = "TB_FacilityID";
            this.TB_FacilityID.ReadOnly = true;
            this.TB_FacilityID.Size = new System.Drawing.Size(100, 20);
            this.TB_FacilityID.TabIndex = 5;
            this.TB_FacilityID.TextChanged += new System.EventHandler(this.TB_FacilityID_TextChanged);
            // 
            // LB_FacilityID
            // 
            this.LB_FacilityID.AutoSize = true;
            this.LB_FacilityID.Location = new System.Drawing.Point(245, 57);
            this.LB_FacilityID.Name = "LB_FacilityID";
            this.LB_FacilityID.Size = new System.Drawing.Size(56, 13);
            this.LB_FacilityID.TabIndex = 4;
            this.LB_FacilityID.Text = "Facility ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(839, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // CMB_FacilityName
            // 
            this.CMB_FacilityName.FormattingEnabled = true;
            this.CMB_FacilityName.Location = new System.Drawing.Point(319, 72);
            this.CMB_FacilityName.Name = "CMB_FacilityName";
            this.CMB_FacilityName.Size = new System.Drawing.Size(234, 21);
            this.CMB_FacilityName.TabIndex = 5;
            this.CMB_FacilityName.SelectedIndexChanged += new System.EventHandler(this.CMB_FacilityName_SelectedIndexChanged);
            // 
            // availability1TableAdapter1
            // 
            this.availability1TableAdapter1.ClearBeforeFill = true;
            // 
            // Form_FacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.CMB_FacilityName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GB_Facility);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.LB_FacilityName);
            this.Name = "Form_FacilityForm";
            this.Text = "Facility Form";
            this.Load += new System.EventHandler(this.Form_FacilityForm_Load);
            this.GB_Facility.ResumeLayout(false);
            this.GB_Facility.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_FacilityName;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.GroupBox GB_Facility;
        private System.Windows.Forms.TextBox TB_Fees;
        private System.Windows.Forms.Label LB_Fees;
        private System.Windows.Forms.TextBox TB_MaxPax;
        private System.Windows.Forms.Label LB_MaxPax;
        private System.Windows.Forms.TextBox TB_FacilityName2;
        private System.Windows.Forms.Label LB_FacilityName2;
        private System.Windows.Forms.TextBox TB_FacilityID;
        private System.Windows.Forms.Label LB_FacilityID;
        private System.Windows.Forms.Button BT_UpdateFacility;
        private System.Windows.Forms.Button BT_CreateFacility;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ComboBox CMB_FacilityName;
        private BookingSystemDataSetTableAdapters.Availability1TableAdapter availability1TableAdapter1;
        private System.Windows.Forms.Button BT_Delete;
    }
}
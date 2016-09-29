namespace SA41Team02B
{
    partial class Cancel_Form
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
            this.LB_Memberid = new System.Windows.Forms.Label();
            this.LB_SlotDate = new System.Windows.Forms.Label();
            this.DGV_Cancel = new System.Windows.Forms.DataGridView();
            this.BT1_Cancel = new System.Windows.Forms.Button();
            this.BT_Search = new System.Windows.Forms.Button();
            this.TB_Memberid = new System.Windows.Forms.TextBox();
            this.BT_Memberid = new System.Windows.Forms.Button();
            this.DTP_Cancel = new System.Windows.Forms.DateTimePicker();
            this.GB_Searchby = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cancel)).BeginInit();
            this.GB_Searchby.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Memberid
            // 
            this.LB_Memberid.AutoSize = true;
            this.LB_Memberid.Location = new System.Drawing.Point(191, 32);
            this.LB_Memberid.Name = "LB_Memberid";
            this.LB_Memberid.Size = new System.Drawing.Size(56, 13);
            this.LB_Memberid.TabIndex = 0;
            this.LB_Memberid.Text = "MemberID";
            // 
            // LB_SlotDate
            // 
            this.LB_SlotDate.AutoSize = true;
            this.LB_SlotDate.Location = new System.Drawing.Point(191, 76);
            this.LB_SlotDate.Name = "LB_SlotDate";
            this.LB_SlotDate.Size = new System.Drawing.Size(48, 13);
            this.LB_SlotDate.TabIndex = 1;
            this.LB_SlotDate.Text = "SlotDate";
            // 
            // DGV_Cancel
            // 
            this.DGV_Cancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cancel.Location = new System.Drawing.Point(60, 228);
            this.DGV_Cancel.Name = "DGV_Cancel";
            this.DGV_Cancel.Size = new System.Drawing.Size(703, 185);
            this.DGV_Cancel.TabIndex = 6;
            // 
            // BT1_Cancel
            // 
            this.BT1_Cancel.Location = new System.Drawing.Point(348, 440);
            this.BT1_Cancel.Name = "BT1_Cancel";
            this.BT1_Cancel.Size = new System.Drawing.Size(142, 23);
            this.BT1_Cancel.TabIndex = 7;
            this.BT1_Cancel.Text = "Cancel Booking";
            this.BT1_Cancel.UseVisualStyleBackColor = true;
            this.BT1_Cancel.Click += new System.EventHandler(this.BT1_Cancel_Click);
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(380, 182);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 8;
            this.BT_Search.Text = "Enter";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // TB_Memberid
            // 
            this.TB_Memberid.Location = new System.Drawing.Point(335, 32);
            this.TB_Memberid.Name = "TB_Memberid";
            this.TB_Memberid.Size = new System.Drawing.Size(121, 20);
            this.TB_Memberid.TabIndex = 9;
            // 
            // BT_Memberid
            // 
            this.BT_Memberid.Location = new System.Drawing.Point(487, 32);
            this.BT_Memberid.Name = "BT_Memberid";
            this.BT_Memberid.Size = new System.Drawing.Size(36, 24);
            this.BT_Memberid.TabIndex = 10;
            this.BT_Memberid.Text = "....";
            this.BT_Memberid.UseVisualStyleBackColor = true;
            this.BT_Memberid.Click += new System.EventHandler(this.BT_Memberid_Click);
            // 
            // DTP_Cancel
            // 
            this.DTP_Cancel.Location = new System.Drawing.Point(335, 76);
            this.DTP_Cancel.Name = "DTP_Cancel";
            this.DTP_Cancel.Size = new System.Drawing.Size(200, 20);
            this.DTP_Cancel.TabIndex = 11;
            // 
            // GB_Searchby
            // 
            this.GB_Searchby.Controls.Add(this.DTP_Cancel);
            this.GB_Searchby.Controls.Add(this.BT_Memberid);
            this.GB_Searchby.Controls.Add(this.LB_Memberid);
            this.GB_Searchby.Controls.Add(this.TB_Memberid);
            this.GB_Searchby.Controls.Add(this.LB_SlotDate);
            this.GB_Searchby.Location = new System.Drawing.Point(34, 27);
            this.GB_Searchby.Name = "GB_Searchby";
            this.GB_Searchby.Size = new System.Drawing.Size(744, 133);
            this.GB_Searchby.TabIndex = 12;
            this.GB_Searchby.TabStop = false;
            this.GB_Searchby.Text = "Search By:";
            // 
            // Cancel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 514);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.BT1_Cancel);
            this.Controls.Add(this.DGV_Cancel);
            this.Controls.Add(this.GB_Searchby);
            this.Name = "Cancel_Form";
            this.Text = "Cancel Booking Form";
            this.Load += new System.EventHandler(this.Cancel_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cancel)).EndInit();
            this.GB_Searchby.ResumeLayout(false);
            this.GB_Searchby.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Memberid;
        private System.Windows.Forms.Label LB_SlotDate;
        private System.Windows.Forms.DataGridView DGV_Cancel;
        private System.Windows.Forms.Button BT1_Cancel;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.TextBox TB_Memberid;
        private System.Windows.Forms.Button BT_Memberid;
        private System.Windows.Forms.DateTimePicker DTP_Cancel;
        private System.Windows.Forms.GroupBox GB_Searchby;
    }
}
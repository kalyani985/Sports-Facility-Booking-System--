namespace SA41Team02B
{
    partial class BookingForm
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
            this.GB_Searchby = new System.Windows.Forms.GroupBox();
            this.LB_Facilityid = new System.Windows.Forms.Label();
            this.BT_Search = new System.Windows.Forms.Button();
            this.DTP_Available = new System.Windows.Forms.DateTimePicker();
            this.CMB_Facilitytype = new System.Windows.Forms.ComboBox();
            this.LB_Dateavailable = new System.Windows.Forms.Label();
            this.LB_Facilitytype = new System.Windows.Forms.Label();
            this.DGV_Available = new System.Windows.Forms.DataGridView();
            this.BT_Booking = new System.Windows.Forms.Button();
            this.LB_Memberid = new System.Windows.Forms.Label();
            this.TB_Memberid = new System.Windows.Forms.TextBox();
            this.BT_Memberid = new System.Windows.Forms.Button();
            this.LB_TransactionID = new System.Windows.Forms.Label();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.LB_Notmemberid = new System.Windows.Forms.Label();
            this.BT_BookCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GB_Searchby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Available)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Searchby
            // 
            this.GB_Searchby.Controls.Add(this.LB_Facilityid);
            this.GB_Searchby.Controls.Add(this.BT_Search);
            this.GB_Searchby.Controls.Add(this.DTP_Available);
            this.GB_Searchby.Controls.Add(this.CMB_Facilitytype);
            this.GB_Searchby.Controls.Add(this.LB_Dateavailable);
            this.GB_Searchby.Controls.Add(this.LB_Facilitytype);
            this.GB_Searchby.Location = new System.Drawing.Point(43, 49);
            this.GB_Searchby.Name = "GB_Searchby";
            this.GB_Searchby.Size = new System.Drawing.Size(708, 192);
            this.GB_Searchby.TabIndex = 0;
            this.GB_Searchby.TabStop = false;
            this.GB_Searchby.Text = "Search By";
            // 
            // LB_Facilityid
            // 
            this.LB_Facilityid.AutoSize = true;
            this.LB_Facilityid.ForeColor = System.Drawing.Color.Red;
            this.LB_Facilityid.Location = new System.Drawing.Point(319, 57);
            this.LB_Facilityid.Name = "LB_Facilityid";
            this.LB_Facilityid.Size = new System.Drawing.Size(29, 13);
            this.LB_Facilityid.TabIndex = 5;
            this.LB_Facilityid.Text = "Error";
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(290, 144);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 4;
            this.BT_Search.Text = "Enter";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // DTP_Available
            // 
            this.DTP_Available.Location = new System.Drawing.Point(313, 84);
            this.DTP_Available.Name = "DTP_Available";
            this.DTP_Available.Size = new System.Drawing.Size(200, 20);
            this.DTP_Available.TabIndex = 3;
            // 
            // CMB_Facilitytype
            // 
            this.CMB_Facilitytype.FormattingEnabled = true;
            this.CMB_Facilitytype.Location = new System.Drawing.Point(313, 33);
            this.CMB_Facilitytype.Name = "CMB_Facilitytype";
            this.CMB_Facilitytype.Size = new System.Drawing.Size(121, 21);
            this.CMB_Facilitytype.TabIndex = 2;
            this.CMB_Facilitytype.SelectedIndexChanged += new System.EventHandler(this.CMB_Facilitytype_SelectedIndexChanged);
            // 
            // LB_Dateavailable
            // 
            this.LB_Dateavailable.AutoSize = true;
            this.LB_Dateavailable.Location = new System.Drawing.Point(164, 91);
            this.LB_Dateavailable.Name = "LB_Dateavailable";
            this.LB_Dateavailable.Size = new System.Drawing.Size(79, 13);
            this.LB_Dateavailable.TabIndex = 1;
            this.LB_Dateavailable.Text = "Date Available:";
            // 
            // LB_Facilitytype
            // 
            this.LB_Facilitytype.AutoSize = true;
            this.LB_Facilitytype.Location = new System.Drawing.Point(174, 36);
            this.LB_Facilitytype.Name = "LB_Facilitytype";
            this.LB_Facilitytype.Size = new System.Drawing.Size(69, 13);
            this.LB_Facilitytype.TabIndex = 0;
            this.LB_Facilitytype.Text = "Facility Type:";
            // 
            // DGV_Available
            // 
            this.DGV_Available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Available.Location = new System.Drawing.Point(43, 276);
            this.DGV_Available.Name = "DGV_Available";
            this.DGV_Available.Size = new System.Drawing.Size(708, 165);
            this.DGV_Available.TabIndex = 1;
            // 
            // BT_Booking
            // 
            this.BT_Booking.Location = new System.Drawing.Point(227, 527);
            this.BT_Booking.Name = "BT_Booking";
            this.BT_Booking.Size = new System.Drawing.Size(103, 23);
            this.BT_Booking.TabIndex = 2;
            this.BT_Booking.Text = "Book";
            this.BT_Booking.UseVisualStyleBackColor = true;
            this.BT_Booking.Click += new System.EventHandler(this.BT_Booking_Click);
            // 
            // LB_Memberid
            // 
            this.LB_Memberid.AutoSize = true;
            this.LB_Memberid.Location = new System.Drawing.Point(224, 476);
            this.LB_Memberid.Name = "LB_Memberid";
            this.LB_Memberid.Size = new System.Drawing.Size(62, 13);
            this.LB_Memberid.TabIndex = 9;
            this.LB_Memberid.Text = "Member ID:";
            // 
            // TB_Memberid
            // 
            this.TB_Memberid.Location = new System.Drawing.Point(353, 473);
            this.TB_Memberid.Name = "TB_Memberid";
            this.TB_Memberid.Size = new System.Drawing.Size(124, 20);
            this.TB_Memberid.TabIndex = 10;
            this.TB_Memberid.TextChanged += new System.EventHandler(this.TB_Memberid_TextChanged);
            // 
            // BT_Memberid
            // 
            this.BT_Memberid.Location = new System.Drawing.Point(530, 473);
            this.BT_Memberid.Name = "BT_Memberid";
            this.BT_Memberid.Size = new System.Drawing.Size(41, 28);
            this.BT_Memberid.TabIndex = 11;
            this.BT_Memberid.Text = "....";
            this.BT_Memberid.UseVisualStyleBackColor = true;
            this.BT_Memberid.Click += new System.EventHandler(this.BT_Memberid_Click);
            // 
            // LB_TransactionID
            // 
            this.LB_TransactionID.AutoSize = true;
            this.LB_TransactionID.Location = new System.Drawing.Point(598, 491);
            this.LB_TransactionID.Name = "LB_TransactionID";
            this.LB_TransactionID.Size = new System.Drawing.Size(0, 13);
            this.LB_TransactionID.TabIndex = 12;
            // 
            // BTN_Print
            // 
            this.BTN_Print.Location = new System.Drawing.Point(404, 527);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(110, 23);
            this.BTN_Print.TabIndex = 13;
            this.BTN_Print.Text = "Print";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // LB_Notmemberid
            // 
            this.LB_Notmemberid.AutoSize = true;
            this.LB_Notmemberid.ForeColor = System.Drawing.Color.Red;
            this.LB_Notmemberid.Location = new System.Drawing.Point(353, 496);
            this.LB_Notmemberid.Name = "LB_Notmemberid";
            this.LB_Notmemberid.Size = new System.Drawing.Size(29, 13);
            this.LB_Notmemberid.TabIndex = 6;
            this.LB_Notmemberid.Text = "Error";
            // 
            // BT_BookCancel
            // 
            this.BT_BookCancel.Location = new System.Drawing.Point(551, 527);
            this.BT_BookCancel.Name = "BT_BookCancel";
            this.BT_BookCancel.Size = new System.Drawing.Size(103, 23);
            this.BT_BookCancel.TabIndex = 14;
            this.BT_BookCancel.Text = "Cancel";
            this.BT_BookCancel.UseVisualStyleBackColor = true;
            this.BT_BookCancel.Click += new System.EventHandler(this.BT_BookCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BT_BookCancel);
            this.Controls.Add(this.LB_Notmemberid);
            this.Controls.Add(this.BTN_Print);
            this.Controls.Add(this.LB_TransactionID);
            this.Controls.Add(this.BT_Memberid);
            this.Controls.Add(this.TB_Memberid);
            this.Controls.Add(this.LB_Memberid);
            this.Controls.Add(this.BT_Booking);
            this.Controls.Add(this.DGV_Available);
            this.Controls.Add(this.GB_Searchby);
            this.Name = "BookingForm";
            this.Text = "Create Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.GB_Searchby.ResumeLayout(false);
            this.GB_Searchby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Available)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Searchby;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.DateTimePicker DTP_Available;
        private System.Windows.Forms.ComboBox CMB_Facilitytype;
        private System.Windows.Forms.Label LB_Dateavailable;
        private System.Windows.Forms.Label LB_Facilitytype;
        private System.Windows.Forms.DataGridView DGV_Available;
        private System.Windows.Forms.Button BT_Booking;
        private System.Windows.Forms.Label LB_Memberid;
        private System.Windows.Forms.TextBox TB_Memberid;
        private System.Windows.Forms.Button BT_Memberid;
        private System.Windows.Forms.Label LB_TransactionID;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Label LB_Facilityid;
        private System.Windows.Forms.Label LB_Notmemberid;
        private System.Windows.Forms.Button BT_BookCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
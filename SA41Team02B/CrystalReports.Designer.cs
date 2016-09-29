namespace SA41Team02B
{
    partial class CrystalReports
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
            this.BTN_MemberList = new System.Windows.Forms.Button();
            this.BTN_OccupancyRate = new System.Windows.Forms.Button();
            this.BTN_BookingTrend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MemberList
            // 
            this.BTN_MemberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MemberList.Location = new System.Drawing.Point(155, 45);
            this.BTN_MemberList.Name = "BTN_MemberList";
            this.BTN_MemberList.Size = new System.Drawing.Size(139, 71);
            this.BTN_MemberList.TabIndex = 0;
            this.BTN_MemberList.Text = "Member List";
            this.BTN_MemberList.UseVisualStyleBackColor = true;
            this.BTN_MemberList.Click += new System.EventHandler(this.BTN_MemberList_Click);
            // 
            // BTN_OccupancyRate
            // 
            this.BTN_OccupancyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OccupancyRate.Location = new System.Drawing.Point(499, 45);
            this.BTN_OccupancyRate.Name = "BTN_OccupancyRate";
            this.BTN_OccupancyRate.Size = new System.Drawing.Size(139, 71);
            this.BTN_OccupancyRate.TabIndex = 1;
            this.BTN_OccupancyRate.Text = "Occupancy Rate";
            this.BTN_OccupancyRate.UseVisualStyleBackColor = true;
            this.BTN_OccupancyRate.Click += new System.EventHandler(this.BTN_OccupancyRate_Click);
            // 
            // BTN_BookingTrend
            // 
            this.BTN_BookingTrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BookingTrend.Location = new System.Drawing.Point(329, 159);
            this.BTN_BookingTrend.Name = "BTN_BookingTrend";
            this.BTN_BookingTrend.Size = new System.Drawing.Size(139, 58);
            this.BTN_BookingTrend.TabIndex = 2;
            this.BTN_BookingTrend.Text = "Booking Trend";
            this.BTN_BookingTrend.UseVisualStyleBackColor = true;
            this.BTN_BookingTrend.Click += new System.EventHandler(this.BTN_BookingTrend_Click);
            // 
            // CrystalReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 256);
            this.Controls.Add(this.BTN_BookingTrend);
            this.Controls.Add(this.BTN_OccupancyRate);
            this.Controls.Add(this.BTN_MemberList);
            this.Name = "CrystalReports";
            this.Text = "CrystalReports";
            this.Load += new System.EventHandler(this.CrystalReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_MemberList;
        private System.Windows.Forms.Button BTN_OccupancyRate;
        private System.Windows.Forms.Button BTN_BookingTrend;
    }
}
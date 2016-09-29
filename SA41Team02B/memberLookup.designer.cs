namespace SA41Team02B
{
    partial class MemberLookUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Member = new System.Windows.Forms.DataGridView();
            this.BT_Ok = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Member);
            this.groupBox1.Location = new System.Drawing.Point(36, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGV_Member
            // 
            this.DGV_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Member.Location = new System.Drawing.Point(20, 26);
            this.DGV_Member.Name = "DGV_Member";
            this.DGV_Member.Size = new System.Drawing.Size(530, 152);
            this.DGV_Member.TabIndex = 0;
            // 
            // BT_Ok
            // 
            this.BT_Ok.Location = new System.Drawing.Point(238, 251);
            this.BT_Ok.Name = "BT_Ok";
            this.BT_Ok.Size = new System.Drawing.Size(75, 23);
            this.BT_Ok.TabIndex = 1;
            this.BT_Ok.Text = "OK";
            this.BT_Ok.UseVisualStyleBackColor = true;
            this.BT_Ok.Click += new System.EventHandler(this.BT_Ok_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(402, 250);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancel.TabIndex = 2;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // MemberLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 326);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberLookUp";
            this.Text = "Member Lookup ";
            this.Load += new System.EventHandler(this.MemberLookUp_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Member)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Member;
        private System.Windows.Forms.Button BT_Ok;
        private System.Windows.Forms.Button BT_Cancel;
    }
}
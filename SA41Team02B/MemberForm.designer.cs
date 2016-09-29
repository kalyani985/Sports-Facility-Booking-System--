namespace SA41Team02B
{
    partial class MemberForm
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
            this.GB_Member = new System.Windows.Forms.GroupBox();
            this.DTB_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.BT_DeleteMember = new System.Windows.Forms.Button();
            this.BT_UpdateDetails = new System.Windows.Forms.Button();
            this.BT_RegisterNewMember = new System.Windows.Forms.Button();
            this.TB_Remarks2 = new System.Windows.Forms.TextBox();
            this.TB_Remarks = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.LB_Address = new System.Windows.Forms.Label();
            this.TB_EmailAddress = new System.Windows.Forms.TextBox();
            this.LB_EmailAddress = new System.Windows.Forms.Label();
            this.RB_Inactive = new System.Windows.Forms.RadioButton();
            this.RB_Active = new System.Windows.Forms.RadioButton();
            this.LB_Stuats = new System.Windows.Forms.Label();
            this.TB_ContactNumber = new System.Windows.Forms.TextBox();
            this.LB_ContactNumber = new System.Windows.Forms.Label();
            this.LB_DateOfBirth = new System.Windows.Forms.Label();
            this.LB_Gender = new System.Windows.Forms.Label();
            this.TB_NRIC = new System.Windows.Forms.TextBox();
            this.LB_NRIC = new System.Windows.Forms.Label();
            this.TB_MemberName2 = new System.Windows.Forms.TextBox();
            this.LB_MemberName2 = new System.Windows.Forms.Label();
            this.LB_MemberID2 = new System.Windows.Forms.Label();
            this.TB_MemberID2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Female = new System.Windows.Forms.RadioButton();
            this.RB_Male = new System.Windows.Forms.RadioButton();
            this.LB_MemberName = new System.Windows.Forms.Label();
            this.TB_MemberName = new System.Windows.Forms.TextBox();
            this.BT_Search = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStrip3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GB_Member.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Member
            // 
            this.GB_Member.Controls.Add(this.DTB_DateOfBirth);
            this.GB_Member.Controls.Add(this.BT_DeleteMember);
            this.GB_Member.Controls.Add(this.BT_UpdateDetails);
            this.GB_Member.Controls.Add(this.BT_RegisterNewMember);
            this.GB_Member.Controls.Add(this.TB_Remarks2);
            this.GB_Member.Controls.Add(this.TB_Remarks);
            this.GB_Member.Controls.Add(this.TB_Address);
            this.GB_Member.Controls.Add(this.LB_Address);
            this.GB_Member.Controls.Add(this.TB_EmailAddress);
            this.GB_Member.Controls.Add(this.LB_EmailAddress);
            this.GB_Member.Controls.Add(this.RB_Inactive);
            this.GB_Member.Controls.Add(this.RB_Active);
            this.GB_Member.Controls.Add(this.LB_Stuats);
            this.GB_Member.Controls.Add(this.TB_ContactNumber);
            this.GB_Member.Controls.Add(this.LB_ContactNumber);
            this.GB_Member.Controls.Add(this.LB_DateOfBirth);
            this.GB_Member.Controls.Add(this.LB_Gender);
            this.GB_Member.Controls.Add(this.TB_NRIC);
            this.GB_Member.Controls.Add(this.LB_NRIC);
            this.GB_Member.Controls.Add(this.TB_MemberName2);
            this.GB_Member.Controls.Add(this.LB_MemberName2);
            this.GB_Member.Controls.Add(this.LB_MemberID2);
            this.GB_Member.Controls.Add(this.TB_MemberID2);
            this.GB_Member.Controls.Add(this.groupBox1);
            this.GB_Member.Location = new System.Drawing.Point(35, 159);
            this.GB_Member.Name = "GB_Member";
            this.GB_Member.Size = new System.Drawing.Size(817, 340);
            this.GB_Member.TabIndex = 4;
            this.GB_Member.TabStop = false;
            this.GB_Member.Text = "Members";
            this.GB_Member.Enter += new System.EventHandler(this.GB_Member_Enter);
            // 
            // DTB_DateOfBirth
            // 
            this.DTB_DateOfBirth.Location = new System.Drawing.Point(151, 174);
            this.DTB_DateOfBirth.Name = "DTB_DateOfBirth";
            this.DTB_DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DTB_DateOfBirth.TabIndex = 19;
            this.DTB_DateOfBirth.ValueChanged += new System.EventHandler(this.DTB_DateOfBirth_ValueChanged);
            // 
            // BT_DeleteMember
            // 
            this.BT_DeleteMember.Location = new System.Drawing.Point(489, 280);
            this.BT_DeleteMember.Name = "BT_DeleteMember";
            this.BT_DeleteMember.Size = new System.Drawing.Size(189, 23);
            this.BT_DeleteMember.TabIndex = 5;
            this.BT_DeleteMember.Text = "Delete Member";
            this.BT_DeleteMember.UseVisualStyleBackColor = true;
            this.BT_DeleteMember.Click += new System.EventHandler(this.BT_DeleteMember_Click);
            // 
            // BT_UpdateDetails
            // 
            this.BT_UpdateDetails.Location = new System.Drawing.Point(280, 280);
            this.BT_UpdateDetails.Name = "BT_UpdateDetails";
            this.BT_UpdateDetails.Size = new System.Drawing.Size(180, 23);
            this.BT_UpdateDetails.TabIndex = 18;
            this.BT_UpdateDetails.Text = "Update Details";
            this.BT_UpdateDetails.UseVisualStyleBackColor = true;
            this.BT_UpdateDetails.Click += new System.EventHandler(this.BT_UpdateDetails_Click);
            // 
            // BT_RegisterNewMember
            // 
            this.BT_RegisterNewMember.Location = new System.Drawing.Point(55, 280);
            this.BT_RegisterNewMember.Name = "BT_RegisterNewMember";
            this.BT_RegisterNewMember.Size = new System.Drawing.Size(197, 23);
            this.BT_RegisterNewMember.TabIndex = 17;
            this.BT_RegisterNewMember.Text = "Register New Member";
            this.BT_RegisterNewMember.UseVisualStyleBackColor = true;
            this.BT_RegisterNewMember.Click += new System.EventHandler(this.BT_RegisterNewMember_Click);
            // 
            // TB_Remarks2
            // 
            this.TB_Remarks2.Location = new System.Drawing.Point(489, 169);
            this.TB_Remarks2.Multiline = true;
            this.TB_Remarks2.Name = "TB_Remarks2";
            this.TB_Remarks2.Size = new System.Drawing.Size(224, 59);
            this.TB_Remarks2.TabIndex = 16;
            // 
            // TB_Remarks
            // 
            this.TB_Remarks.AutoSize = true;
            this.TB_Remarks.Location = new System.Drawing.Point(419, 162);
            this.TB_Remarks.Name = "TB_Remarks";
            this.TB_Remarks.Size = new System.Drawing.Size(52, 13);
            this.TB_Remarks.TabIndex = 5;
            this.TB_Remarks.Text = "Remarks:";
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(489, 113);
            this.TB_Address.Multiline = true;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(224, 33);
            this.TB_Address.TabIndex = 5;
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(423, 116);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(48, 13);
            this.LB_Address.TabIndex = 15;
            this.LB_Address.Text = "Address:";
            // 
            // TB_EmailAddress
            // 
            this.TB_EmailAddress.Location = new System.Drawing.Point(489, 73);
            this.TB_EmailAddress.Name = "TB_EmailAddress";
            this.TB_EmailAddress.Size = new System.Drawing.Size(113, 20);
            this.TB_EmailAddress.TabIndex = 14;
            // 
            // LB_EmailAddress
            // 
            this.LB_EmailAddress.AutoSize = true;
            this.LB_EmailAddress.Location = new System.Drawing.Point(395, 76);
            this.LB_EmailAddress.Name = "LB_EmailAddress";
            this.LB_EmailAddress.Size = new System.Drawing.Size(76, 13);
            this.LB_EmailAddress.TabIndex = 5;
            this.LB_EmailAddress.Text = "Email Address:";
            // 
            // RB_Inactive
            // 
            this.RB_Inactive.AutoSize = true;
            this.RB_Inactive.Location = new System.Drawing.Point(571, 36);
            this.RB_Inactive.Name = "RB_Inactive";
            this.RB_Inactive.Size = new System.Drawing.Size(63, 17);
            this.RB_Inactive.TabIndex = 13;
            this.RB_Inactive.Text = "Inactive";
            this.RB_Inactive.UseVisualStyleBackColor = true;
            // 
            // RB_Active
            // 
            this.RB_Active.AutoSize = true;
            this.RB_Active.Location = new System.Drawing.Point(489, 36);
            this.RB_Active.Name = "RB_Active";
            this.RB_Active.Size = new System.Drawing.Size(55, 17);
            this.RB_Active.TabIndex = 12;
            this.RB_Active.Text = "Active";
            this.RB_Active.UseVisualStyleBackColor = true;
            // 
            // LB_Stuats
            // 
            this.LB_Stuats.AutoSize = true;
            this.LB_Stuats.Location = new System.Drawing.Point(431, 38);
            this.LB_Stuats.Name = "LB_Stuats";
            this.LB_Stuats.Size = new System.Drawing.Size(40, 13);
            this.LB_Stuats.TabIndex = 11;
            this.LB_Stuats.Text = "Status:";
            this.LB_Stuats.Click += new System.EventHandler(this.LB_Stuats_Click);
            // 
            // TB_ContactNumber
            // 
            this.TB_ContactNumber.Location = new System.Drawing.Point(150, 208);
            this.TB_ContactNumber.Name = "TB_ContactNumber";
            this.TB_ContactNumber.Size = new System.Drawing.Size(100, 20);
            this.TB_ContactNumber.TabIndex = 10;
            // 
            // LB_ContactNumber
            // 
            this.LB_ContactNumber.AutoSize = true;
            this.LB_ContactNumber.Location = new System.Drawing.Point(52, 210);
            this.LB_ContactNumber.Name = "LB_ContactNumber";
            this.LB_ContactNumber.Size = new System.Drawing.Size(90, 13);
            this.LB_ContactNumber.TabIndex = 9;
            this.LB_ContactNumber.Text = "Contact Number: ";
            // 
            // LB_DateOfBirth
            // 
            this.LB_DateOfBirth.AutoSize = true;
            this.LB_DateOfBirth.Location = new System.Drawing.Point(73, 176);
            this.LB_DateOfBirth.Name = "LB_DateOfBirth";
            this.LB_DateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.LB_DateOfBirth.TabIndex = 8;
            this.LB_DateOfBirth.Text = "Date of Birth:";
            // 
            // LB_Gender
            // 
            this.LB_Gender.AutoSize = true;
            this.LB_Gender.Location = new System.Drawing.Point(97, 145);
            this.LB_Gender.Name = "LB_Gender";
            this.LB_Gender.Size = new System.Drawing.Size(45, 13);
            this.LB_Gender.TabIndex = 5;
            this.LB_Gender.Text = "Gender:";
            // 
            // TB_NRIC
            // 
            this.TB_NRIC.Location = new System.Drawing.Point(150, 109);
            this.TB_NRIC.Name = "TB_NRIC";
            this.TB_NRIC.Size = new System.Drawing.Size(90, 20);
            this.TB_NRIC.TabIndex = 5;
            // 
            // LB_NRIC
            // 
            this.LB_NRIC.AutoSize = true;
            this.LB_NRIC.Location = new System.Drawing.Point(106, 113);
            this.LB_NRIC.Name = "LB_NRIC";
            this.LB_NRIC.Size = new System.Drawing.Size(36, 13);
            this.LB_NRIC.TabIndex = 4;
            this.LB_NRIC.Text = "NRIC:";
            // 
            // TB_MemberName2
            // 
            this.TB_MemberName2.Location = new System.Drawing.Point(149, 71);
            this.TB_MemberName2.Name = "TB_MemberName2";
            this.TB_MemberName2.Size = new System.Drawing.Size(171, 20);
            this.TB_MemberName2.TabIndex = 3;
            this.TB_MemberName2.TextChanged += new System.EventHandler(this.TB_MemberName2_TextChanged);
            // 
            // LB_MemberName2
            // 
            this.LB_MemberName2.AutoSize = true;
            this.LB_MemberName2.Location = new System.Drawing.Point(64, 76);
            this.LB_MemberName2.Name = "LB_MemberName2";
            this.LB_MemberName2.Size = new System.Drawing.Size(79, 13);
            this.LB_MemberName2.TabIndex = 2;
            this.LB_MemberName2.Text = "Member Name:";
            // 
            // LB_MemberID2
            // 
            this.LB_MemberID2.AutoSize = true;
            this.LB_MemberID2.Location = new System.Drawing.Point(81, 38);
            this.LB_MemberID2.Name = "LB_MemberID2";
            this.LB_MemberID2.Size = new System.Drawing.Size(62, 13);
            this.LB_MemberID2.TabIndex = 1;
            this.LB_MemberID2.Text = "Member ID:";
            // 
            // TB_MemberID2
            // 
            this.TB_MemberID2.Location = new System.Drawing.Point(149, 38);
            this.TB_MemberID2.Name = "TB_MemberID2";
            this.TB_MemberID2.ReadOnly = true;
            this.TB_MemberID2.Size = new System.Drawing.Size(73, 20);
            this.TB_MemberID2.TabIndex = 0;
            this.TB_MemberID2.TextChanged += new System.EventHandler(this.TB_MemberID2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Female);
            this.groupBox1.Controls.Add(this.RB_Male);
            this.groupBox1.Location = new System.Drawing.Point(148, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 33);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // RB_Female
            // 
            this.RB_Female.AutoSize = true;
            this.RB_Female.Location = new System.Drawing.Point(73, 11);
            this.RB_Female.Name = "RB_Female";
            this.RB_Female.Size = new System.Drawing.Size(59, 17);
            this.RB_Female.TabIndex = 7;
            this.RB_Female.TabStop = true;
            this.RB_Female.Text = "Female";
            this.RB_Female.UseVisualStyleBackColor = true;
            // 
            // RB_Male
            // 
            this.RB_Male.AutoSize = true;
            this.RB_Male.Location = new System.Drawing.Point(19, 11);
            this.RB_Male.Name = "RB_Male";
            this.RB_Male.Size = new System.Drawing.Size(48, 17);
            this.RB_Male.TabIndex = 6;
            this.RB_Male.TabStop = true;
            this.RB_Male.Text = "Male";
            this.RB_Male.UseVisualStyleBackColor = true;
            this.RB_Male.CheckedChanged += new System.EventHandler(this.RB_Male_CheckedChanged);
            // 
            // LB_MemberName
            // 
            this.LB_MemberName.AutoSize = true;
            this.LB_MemberName.Location = new System.Drawing.Point(167, 79);
            this.LB_MemberName.Name = "LB_MemberName";
            this.LB_MemberName.Size = new System.Drawing.Size(131, 13);
            this.LB_MemberName.TabIndex = 2;
            this.LB_MemberName.Text = "Search By Member Name:";
            // 
            // TB_MemberName
            // 
            this.TB_MemberName.Location = new System.Drawing.Point(327, 76);
            this.TB_MemberName.Name = "TB_MemberName";
            this.TB_MemberName.Size = new System.Drawing.Size(234, 20);
            this.TB_MemberName.TabIndex = 3;
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(651, 74);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 16;
            this.BT_Search.Text = "Enter";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip3
            // 
            this.StatusStrip3.Name = "StatusStrip3";
            this.StatusStrip3.Size = new System.Drawing.Size(0, 17);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.GB_Member);
            this.Controls.Add(this.TB_MemberName);
            this.Controls.Add(this.LB_MemberName);
            this.Name = "MemberForm";
            this.Text = "Member Form";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.GB_Member.ResumeLayout(false);
            this.GB_Member.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Member;
        private System.Windows.Forms.RadioButton RB_Female;
        private System.Windows.Forms.RadioButton RB_Male;
        private System.Windows.Forms.TextBox TB_NRIC;
        private System.Windows.Forms.Label LB_NRIC;
        private System.Windows.Forms.TextBox TB_MemberName2;
        private System.Windows.Forms.Label LB_MemberName2;
        private System.Windows.Forms.Label LB_MemberID2;
        private System.Windows.Forms.TextBox TB_MemberID2;
        private System.Windows.Forms.Label LB_Stuats;
        private System.Windows.Forms.TextBox TB_ContactNumber;
        private System.Windows.Forms.Label LB_ContactNumber;
        private System.Windows.Forms.Label LB_DateOfBirth;
        private System.Windows.Forms.Button BT_DeleteMember;
        private System.Windows.Forms.Button BT_UpdateDetails;
        private System.Windows.Forms.Button BT_RegisterNewMember;
        private System.Windows.Forms.TextBox TB_Remarks2;
        private System.Windows.Forms.Label TB_Remarks;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.TextBox TB_EmailAddress;
        private System.Windows.Forms.Label LB_EmailAddress;
        private System.Windows.Forms.RadioButton RB_Inactive;
        private System.Windows.Forms.RadioButton RB_Active;
        private System.Windows.Forms.Label LB_MemberName;
        private System.Windows.Forms.TextBox TB_MemberName;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.DateTimePicker DTB_DateOfBirth;
        private System.Windows.Forms.Label LB_Gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip3;
    }
}
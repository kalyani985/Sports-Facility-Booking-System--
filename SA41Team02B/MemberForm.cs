using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA41Team02B
{
    public partial class MemberForm : Form
    {

        BookingSystemEntities context;
        Member m;

        Member m1 = new Member();
        public MemberForm()
        {
            InitializeComponent();
            context = new BookingSystemEntities();
            ToolTip NRICtooltip = new ToolTip();
            NRICtooltip.SetToolTip(this.LB_NRIC, "Identification Number");

            ToolTip StatusToolTip = new ToolTip();
            StatusToolTip.SetToolTip(this.RB_Inactive, "Status will be deactivated if membership is no longer active.");

        }

        private void LB_Stuats_Click(object sender, EventArgs e)
        {

        }

        private void BT_Search_Click(object sender, EventArgs e)

        {
           
            var q = from x in context.Members where x.MemberName.Contains(TB_MemberName.Text)  select x;        
      
           try{
               m = q.First();
               TB_MemberID2.Text = m.MemberID;
               TB_MemberName2.Text = m.MemberName;
               TB_NRIC.Text = m.NRIC;


               if (m.Gender == "M")

                   RB_Male.Checked = true;

               else if (m.Gender == "F")

                   RB_Female.Checked = true;



               DTB_DateOfBirth.Text = m.DateOfBirth.ToString();
               TB_ContactNumber.Text = m.ContactNumber.ToString();


               if (m.Status == "Active")
                   RB_Active.Checked = true;
               else if (m.Status == "Inactive")
                   RB_Inactive.Checked = true;


               TB_EmailAddress.Text = m.EmailAddress;
               TB_Address.Text = m.Address;
               TB_Remarks2.Text = m.Remarks;
           }
            catch
           {
            MessageBox.Show("No Members Found. Please try again.");
            }
           }

        

        private void BT_RegisterNewMember_Click(object sender, EventArgs e)
        {
            string[] memberids = (from x in context.Members select x.MemberID).ToArray();
            var lastvalue = memberids[memberids.Length - 1];
            string numberinstring = lastvalue.Substring(1, 3);
            int number = Convert.ToInt32(numberinstring);
            int count = 0;
            count++;
            count = count + number;

            string numbertostring = count.ToString("000");
            string a = string.Concat("C", numbertostring);
            TB_MemberID2.Text = a;
            m1.MemberID = TB_MemberID2.Text;


            RB_Inactive.Enabled = false;

            RB_Active.Checked = true;
          
            
         
                      
            TB_MemberName2.Clear();
            TB_NRIC.Clear();
            if (RB_Male.Checked == true)
                RB_Male.Checked = false;
            if (RB_Female.Checked == true)
                RB_Female.Checked = false;
            DTB_DateOfBirth.ResetText();
            TB_ContactNumber.Clear();
           
           if (RB_Inactive.Checked == true )
                RB_Inactive.Checked = false;
            TB_EmailAddress.Clear();
            TB_Address.Clear();
            TB_Remarks2.Clear();

           
        }

        private void BT_UpdateDetails_Click(object sender, EventArgs e)
        {

            if (TB_MemberID2.Text == m1.MemberID)
            {

                m1.MemberID = TB_MemberID2.Text;
                m1.MemberName = TB_MemberName2.Text;
                m1.NRIC = TB_NRIC.Text;

                if (TB_NRIC.Text.Length != 9)
                {
                    MessageBox.Show("NRIC should be 9 characters long.");
                }
                else
                {
                    if (RB_Male.Checked == true)
                    m1.Gender = "M";
                else if (RB_Female.Checked == true)
                    m1.Gender = "F";
                m1.DateOfBirth = Convert.ToDateTime(DTB_DateOfBirth.Text);
                m1.ContactNumber = Convert.ToInt32(TB_ContactNumber.Text);
                if (RB_Active.Checked == true)
                    m1.Status = "Active";
                else if (RB_Inactive.Checked == true)
                    m1.Status = "Inactive";
                m1.EmailAddress = TB_EmailAddress.Text;
                m1.Address = TB_Address.Text;
                m1.Remarks = TB_Remarks2.Text;
                context.Members.Add(m1);
                context.SaveChanges();
                StatusStrip3.Text = "Member Details Added.";
                }
                
            }
            else if (TB_MemberID2.Text == m.MemberID)
            {

                m.MemberID = TB_MemberID2.Text;
                m.MemberName = TB_MemberName2.Text;
                m.NRIC = TB_NRIC.Text;



                if (RB_Male.Checked == true)
                    m.Gender = "M";
                else if (RB_Female.Checked == true)
                    m.Gender = "F";


                m.DateOfBirth = Convert.ToDateTime(DTB_DateOfBirth.Text);
                m.ContactNumber = Convert.ToInt32(TB_ContactNumber.Text);


                if (RB_Active.Checked == true)
                    m.Status = "Active";

                else if (RB_Inactive.Checked == true)
                    m.Status = "Inactive";


                m.EmailAddress = TB_EmailAddress.Text;
                m.Address = TB_Address.Text;
                m.Remarks = TB_Remarks2.Text;


                context.SaveChanges();
                StatusStrip3.Text = "Member Details Updated.";
            }
            else 
            {
                MessageBox.Show("Please try again.");

                TB_MemberID2.Clear();
                TB_MemberName2.Clear();
                TB_NRIC.Clear();
                if (RB_Male.Checked == true)
                    RB_Male.Checked = false;
                else if (RB_Female.Checked == true)
                    RB_Female.Checked = false;
                DTB_DateOfBirth.ResetText();
                TB_ContactNumber.Clear();
                if (RB_Active.Checked == true)
                    RB_Active.Checked = false;
                else if (RB_Inactive.Checked == true)
                    RB_Inactive.Checked = false;
                TB_EmailAddress.Clear();
                TB_Address.Clear();
                TB_Remarks2.Clear();


                
            }
        }

        private void BT_DeleteMember_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Confirm Delete Member?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var q1 = from x in context.Members where x.MemberName == TB_MemberName2.Text select x;
                Member m2 = q1.First();
                m2.Status = "Inactive";
                context.SaveChanges();

                TB_MemberID2.Clear();
                TB_MemberName2.Clear();
                TB_NRIC.Clear();
                if (RB_Male.Checked == true)
                    RB_Male.Checked = false;

                else if (RB_Female.Checked == true)
                    RB_Female.Checked = false;

                DTB_DateOfBirth.ResetText();
                TB_ContactNumber.Clear();

                  if (RB_Active.Checked == true)
                    RB_Active.Checked = false;

                else if (RB_Inactive.Checked == true)
                    RB_Inactive.Checked = false;

                TB_EmailAddress.Clear();
                TB_Address.Clear();
                TB_Remarks2.Clear();

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
            
            
           
        }

        private void DTB_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_MemberName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RB_Male_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void GB_Member_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
           }

        private void MemberForm_Load(object sender, EventArgs e)
        {
           
        }

        private void TB_MemberID2_TextChanged(object sender, EventArgs e)
        {

        }
            
           }
        
}   
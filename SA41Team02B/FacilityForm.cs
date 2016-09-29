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
    public partial class Form_FacilityForm : Form
    {
        BookingSystemEntities context= new BookingSystemEntities();
        
        Facility f;

        Facility f1 = new Facility();
        
        public Form_FacilityForm()
        {
            InitializeComponent();
            
           
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            var r = from x in context.Facilities where x.FacilityName == CMB_FacilityName.Text select x;

           
                f = r.First();
                TB_FacilityID.Text = f.FacilityID;
                TB_FacilityName2.Text = f.FacilityName;
                TB_MaxPax.Text = f.MaxOfPeople.ToString();
                TB_Fees.Text = f.Fees.ToString();

                
            
        }

        private void BT_CreateFacility_Click(object sender, EventArgs e)
        {


            string[] facilityids = (from x in context.Facilities select x.FacilityID).ToArray();
            var lastvalue = facilityids[facilityids.Length - 1];
            string numberinstring = lastvalue.Substring(1, 3);
            int number = Convert.ToInt32(numberinstring);
            int count = 0;
            count++;
            count = count + number;

            string numbertostring = count.ToString("000");
            string a = string.Concat("F", numbertostring);
            TB_FacilityID.Text = a;
            f1.FacilityID = TB_FacilityID.Text;




            
            TB_FacilityName2.Clear();
            TB_MaxPax.Clear();
            TB_Fees.Clear();
            
            
            
           
             
        }

        private void BT_UpdateFacility_Click(object sender, EventArgs e)
        {
            if (TB_FacilityID.Text == f1.FacilityID)          
            {

                f1.FacilityID = TB_FacilityID.Text;
                f1.FacilityName = TB_FacilityName2.Text;
                f1.MaxOfPeople = Convert.ToInt16(TB_MaxPax.Text);
                f1.Fees = Convert.ToInt16(TB_Fees.Text);
                CMB_FacilityName.Items.Add(TB_FacilityName2.Text);
                context.Facilities.Add(f1);
                context.SaveChanges();

               

                toolStripStatusLabel2.Text = "Facility is added.";
            }

                else if (TB_FacilityID.Text == f.FacilityID)

            {
                   
                    f.FacilityID = TB_FacilityID.Text;
                f.FacilityName = TB_FacilityName2.Text;
                    f.MaxOfPeople = Convert.ToInt16(TB_MaxPax.Text);
              f.Fees = Convert.ToInt16(TB_Fees.Text);
              toolStripStatusLabel2.Text = "Facility is updated.";


           
             
              
            }
            else
            {
                MessageBox.Show("Please try again.");

                TB_FacilityID.Clear();
                TB_FacilityName2.Clear();
                TB_MaxPax.Clear();
                TB_Fees.Clear();
            }
                       

                   
            context.SaveChanges();
        }

        private void Form_FacilityForm_Load(object sender, EventArgs e)
        {

            string[] facilitynames= (from x in context.Facilities select x.FacilityName).ToArray();

            for (int i=0; i<facilitynames.Length; i++)
            {
                CMB_FacilityName.Items.Add(facilitynames[i]);
            }

            


            
        }

        private void GB_Facility_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void TB_FacilityID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            var w = from x in context.Facilities where x.FacilityID == TB_FacilityID.Text select x;
            Facility c2 = w.First();
          
            context.Facilities.Remove(c2);
            context.SaveChanges();

            string[] facilitynames = (from x in context.Facilities select x.FacilityName).ToArray();

            for (int i = 0; i < facilitynames.Length; i++)
            {
               
                CMB_FacilityName.Items.Remove(facilitynames[i]);
            }

            string[] facilitynames2 = (from x in context.Facilities select x.FacilityName).ToArray();

            for (int i = 0; i < facilitynames2.Length; i++)
            {

                CMB_FacilityName.Items.Add(facilitynames2[i]);
            }

         

            TB_FacilityID.Clear();
            TB_FacilityName2.Clear();
            TB_MaxPax.Clear();
            TB_Fees.Clear();
        }



        private void CMB_FacilityName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void BT_First_Click(object sender, EventArgs e)
        //{
        //    

        //}

        //private void PopulateFields()
        //{
            
            
        //    
        //}
    }
}

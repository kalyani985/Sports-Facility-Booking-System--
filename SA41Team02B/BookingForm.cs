using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA41Team02B
{
    public partial class BookingForm : Form
    {

        BookingSystemEntities ctx = new BookingSystemEntities();
        public BookingForm()
        {
            InitializeComponent();
        }
      
        private void BT_Search_Click(object sender, EventArgs e)
        {
            //ctx = new BookingSystemEntities();
            if (CMB_Facilitytype.Text == "")
            {
                LB_Facilityid.Enabled = true;
                LB_Facilityid.Text = "Select FacilityType";
            }
            else
                LB_Facilityid.Enabled = false;
          
         var avl = from x in ctx.Availabilities where x.FacilityName == CMB_Facilitytype.Text.ToString() && x.SlotDate == DTP_Available.Value.Date && x.SlotAvailability=="A" select x;
          var result = avl.ToList();
          
           DGV_Available.DataSource = result;
           DGV_Available.Columns["Facility"].Visible = false;
           DGV_Available.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         

          
        }


              
       private void button1_Click(object sender, EventArgs e)
        {
          
            }

       private void CMB_Facilitytype_SelectedIndexChanged(object sender, EventArgs e) 
       {
           LB_Facilityid.Enabled = false;
           LB_Facilityid.Text = "";
       }

       private void BT_Booking_Click(object sender, EventArgs e)
       {
           if (TB_Memberid.Text == "")
           {
               LB_Notmemberid.Enabled = true;
               LB_Notmemberid.Text = "Pls Enter MemberID";
           }
           else
               LB_Facilityid.Enabled = false;
           BookingSystemEntities ctx = new BookingSystemEntities();
           Tran ts = new Tran();
           string facilityType = DGV_Available.SelectedCells[0].Value.ToString();
           string slotTime = DGV_Available.SelectedCells[2].Value.ToString();
           
           ts.MemberID = TB_Memberid.Text;
           ts.FacilityID = facilityType;
           ts.SlotDate = DTP_Available.Value.Date; //Convert.ToDateTime(DGV_Available.SelectedCells[3].Value.ToString()); ;
           ts.SlotTime = DGV_Available.SelectedCells[2].Value.ToString();
           ts.DateBooking = DateTime.Today;
           ts.Action = BT_Booking.Text;
           ctx.Trans.Add(ts);

           
           Availability a = (from x in ctx.Availabilities where x.FacilityID == facilityType && x.SlotDate == DTP_Available.Value.Date && x.SlotTime == slotTime select x).First();  
            a.SlotAvailability = "NA";
         
           ctx.SaveChanges();
           toolStripStatusLabel1.Text="Booking is Successful.";
           BT_Search.PerformClick();
            
            
       }

       private void BookingForm_Load(object sender, EventArgs e)
       {
           LB_Facilityid.Enabled = false;
           LB_Facilityid.Text = "";
           LB_Notmemberid.Enabled = false;
           LB_Notmemberid.Text = "";


           //string[] bookingformfacilitynames = 
           
           string[] booking = (from x in ctx.Facilities select x.FacilityName).ToArray();

           for (int i = 0; i < booking.Length; i++)
           {
               CMB_Facilitytype.Items.Add(booking[i]);
           }

           DTP_Available.MinDate = new DateTime(2015, 10, 20);
           DTP_Available.MaxDate = new DateTime(2015, 10, 21);
          
       }

       private void BT_Memberid_Click(object sender, EventArgs e)
       {
           MemberLookUp member = new MemberLookUp();
           DialogResult r = member.ShowDialog();
           if(r==DialogResult.OK)
           {
               TB_Memberid.Text = member.SelectedCust;
           }
       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void BTN_Print_Click(object sender, EventArgs e)
       {
           cRpt_BookingReceipt form = new cRpt_BookingReceipt();
            form.Show();
       }

       private void TB_Memberid_TextChanged(object sender, EventArgs e)
       {
           LB_Notmemberid.Enabled = false;
           LB_Notmemberid.Text = "";
       }

       private void BT_BookCancel_Click(object sender, EventArgs e)
       {
           DGV_Available.DataSource = "";
           TB_Memberid.Text = "";
       }

       

           
              
        }

                  
    }


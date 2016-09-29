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
    public partial class Cancel_Form : Form
    {
        CancelController controller;
        public Cancel_Form()
        {
            InitializeComponent();
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
           
            BookingSystemEntities ctx = new BookingSystemEntities();
            DateTime SlotDate = DTP_Cancel.Value.Date ; //Convert.ToDateTime(TB_SlotDate.Text)
            var atr = from x in ctx.Trans where x.MemberID == TB_Memberid.Text.ToString() && x.SlotDate ==  SlotDate && x.Action=="Book" select x;
            var result = atr.ToList();
          
           DGV_Cancel.DataSource = result;
           DGV_Cancel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         
          
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
           /* controller = new CancelController();
            string memberID = TB_Memberid.Text;
            DateTime SlotDate = DTP_Cancel.Value.Date;
            string SlotTime = DGV_Cancel.SelectedCells[4].Value.ToString();

            controller.GetTran(memberID,SlotDate,SlotTime);

           
            string FacilityID = DGV_Cancel.SelectedCells[2].Value.ToString();
           
             DateTime SlotDate1 = (Convert.ToDateTime(DGV_Cancel.SelectedCells[3].Value)).Date;
             controller.SetAvail(FacilityID, SlotTime, SlotDate1);
            */
            
        }

        private void Cancel_Form_Load(object sender, EventArgs e)
        {
          /* DTP_Cancel.MinDate = new DateTime(2015, 11, 15);           

            DTP_Cancel.MaxDate = new DateTime(2015, 11, 16);*/
            

        }

        private void LBSlotTime_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void BT_Memberid_Click(object sender, EventArgs e)
        {
            MemberLookUp member = new MemberLookUp();
            DialogResult r = member.ShowDialog();
            if (r == DialogResult.OK)
            {
                TB_Memberid.Text = member.SelectedCust;
            }
        }

        private void LBSlotTime(object sender, KeyPressEventArgs e)
        {

        }

        private void BT1_Cancel_Click(object sender, EventArgs e)
        {
            controller = new CancelController();
            string memberID = TB_Memberid.Text;
            
            DateTime SlotDate1 = (Convert.ToDateTime(DGV_Cancel.SelectedCells[3].Value)).Date;
            
            string SlotTime = DGV_Cancel.SelectedCells[4].Value.ToString();

            controller.GetTran(memberID, SlotDate1, SlotTime);

            
            //string FacilityID = DGV_Cancel.SelectedCells[2].Value.ToString();            
            
            //controller.SetAvail(FacilityID, SlotTime, SlotDate1);

            BT_Search.PerformClick();

        }

        private void TB_Memberid_Leave(object sender, EventArgs e)
        {
            if (TB_Memberid.Text == "")
            {
                MessageBox.Show("You Cant Leave This Text");
                TB_Memberid.Focus();
            }
                    

        }
    }
}

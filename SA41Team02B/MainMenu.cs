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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReports crystalreport1 = new CrystalReports();
            crystalreport1.MdiParent = this;
            
            crystalreport1.Show();
           // cRpt_form.ShowDialog();
           // cRpt_form.Dispose();

        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm memberform = new MemberForm();
            memberform.MdiParent = this;
            
            memberform.Show();
           
        }

        private void maintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Form_FacilityForm facilityform1 = new Form_FacilityForm();
           facilityform1.MdiParent = this;
           
            facilityform1.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            BookingForm bookingform1 = new BookingForm();
            bookingform1.MdiParent = this;
            
            bookingform1.Show();            
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel_Form cancelform1 = new Cancel_Form();
            cancelform1.MdiParent = this;

            cancelform1.Show();
        }
    }
}

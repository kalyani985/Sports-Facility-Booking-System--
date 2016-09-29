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
    public partial class CrystalReports : Form
    {
        public CrystalReports()
        {
            InitializeComponent();
        }

        private void BTN_MemberList_Click(object sender, EventArgs e)
        {
            cRpt_MemberList form = new cRpt_MemberList();
            form.Show();
        }

        private void BTN_OccupancyRate_Click(object sender, EventArgs e)
        {
            cRpt_OccupancyRate form = new cRpt_OccupancyRate();
            form.Show();
        }

        private void CrystalReports_Load(object sender, EventArgs e)
        {
           

        }

        private void BTN_BookingReceipt_Click(object sender, EventArgs e)
        {

            cRpt_BookingReceipt form = new cRpt_BookingReceipt();
            form.Show();
        }

        private void BTN_BookingTrend_Click(object sender, EventArgs e)
        {
            cRpt_BookingTrendChart form = new cRpt_BookingTrendChart();
            form.Show();
        }
    }
}

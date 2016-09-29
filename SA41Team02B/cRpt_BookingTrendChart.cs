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
    public partial class cRpt_BookingTrendChart : Form
    {
        public cRpt_BookingTrendChart()
        {
            InitializeComponent();
        }

        private void cRpt_BookingTrendChart_Load(object sender, EventArgs e)
        {
            BookingSystemDataSet ds = new BookingSystemDataSet ();
          BookingSystemDataSetTableAdapters.Availability1TableAdapter ta = new BookingSystemDataSetTableAdapters.Availability1TableAdapter ();
             RPT_BookingTrend cRptBookingTrend = new RPT_BookingTrend ();
            ta.Fill(ds.Availability1);
            cRptBookingTrend.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRptBookingTrend;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

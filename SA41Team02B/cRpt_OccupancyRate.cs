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
    public partial class cRpt_OccupancyRate : Form
    {
        public cRpt_OccupancyRate()
        {
            InitializeComponent();
        }

        private void cRpt_OccupancyRate_Load(object sender, EventArgs e)
        {
            BookingSystemDataSet ds = new BookingSystemDataSet();
            BookingSystemDataSetTableAdapters.AvailabilityTableAdapter ta = new BookingSystemDataSetTableAdapters.AvailabilityTableAdapter();
            RPT_OccupancyByFacility cRptOccupancyRate = new RPT_OccupancyByFacility();
            ta.Fill(ds.Availability);
            cRptOccupancyRate.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRptOccupancyRate;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
             
        }
        }
    }

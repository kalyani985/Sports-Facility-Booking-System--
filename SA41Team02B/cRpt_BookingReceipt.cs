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
    public partial class cRpt_BookingReceipt : Form
    {
        public cRpt_BookingReceipt()
        {
            InitializeComponent();
        }

        private void cRpt_BookingReceipt_Load(object sender, EventArgs e)
        {
          BookingSystemDataSet ds = new BookingSystemDataSet ();
          BookingSystemDataSetTableAdapters.Trans1TableAdapter ta = new BookingSystemDataSetTableAdapters.Trans1TableAdapter ();
          RPT_BookingReceipt cRptBReceipt = new RPT_BookingReceipt ();
                 
            ta.GetData();
            ta.Fill(ds.Trans1);

            cRptBReceipt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRptBReceipt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        
        }
        }
    }

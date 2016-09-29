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
    public partial class cRpt_MemberList : Form
    {
        public cRpt_MemberList()
        {
            InitializeComponent();
        }

        private void cRpt_MemberList_Load(object sender, EventArgs e)
        {
            BookingSystemDataSet ds = new BookingSystemDataSet();
            BookingSystemDataSetTableAdapters.MembersTableAdapter ta = new BookingSystemDataSetTableAdapters.MembersTableAdapter();
            RPT_MemberList cRptMembers = new RPT_MemberList();
            ta.Fill(ds.Members);
            cRptMembers.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRptMembers;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        
        }
        }
    }


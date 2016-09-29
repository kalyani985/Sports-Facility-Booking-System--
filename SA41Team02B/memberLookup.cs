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
    public partial class MemberLookUp : Form
    {
        public string SelectedCust
        {
            get { return DGV_Member.CurrentRow.Cells[0].Value.ToString(); }
        }
        public MemberLookUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MemberLookUp_Load(object sender, EventArgs e)
        {
           
            BookingSystemEntities ctx=new BookingSystemEntities();
            var query=from x in ctx.Members where x.Status=="Active" select x;
            var result=query.ToList();

            DGV_Member.DataSource = result;
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BT_Ok_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
        }
    }
}

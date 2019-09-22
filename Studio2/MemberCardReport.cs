using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio2
{
    public partial class MemberCardReport : Form
    {
        public MemberCardReport()
        {
            InitializeComponent();
        }

        private void MemberCardReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetMember.Member' table. You can move, or remove it, as needed.
            this.MemberTableAdapter.Fill(this.DataSetMember.Member, AddNewMember._member.memberID);

            this.reportViewer1.RefreshReport();
        }
    }
}

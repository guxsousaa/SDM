using SDM.FRMs_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_Ad : Form
    {
        public FRM_Ad()
        {
            InitializeComponent();
        }

        private void FRM_Ad_Load(object sender, EventArgs e)
        {
            //list_computer_ad.Items.Add(new ListViewItem(AdHelper.GetComputers().ToArray()));
        }

        private void btn_new_computer_Click(object sender, EventArgs e)
        {
            FRM_newComp frm_newComp = new FRM_newComp();
            frm_newComp.Show();
        }
    }
}

using DTO_AD;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SDM
{
    public partial class FRM_Ad : Form
    {
        public FRM_Ad()
        {
            InitializeComponent();

            if (AdHelper.AD.Count > 0)
                txt_allComputer_ad.Text = AdHelper.AD.Count.ToString().Insert(2, ".");
            else txt_allComputer_ad.Text = "0";

            DateTime dt = DateTime.Now.Date;
            DateTime dtAD = ToolsHelper.checkLastBaseCompChange();
            if (dt.Day == dtAD.Day)
                txt_details_from_ad.Text = "Detalhes de " + dtAD.ToString().Split(' ')[1];
            else
                txt_details_from_ad.Text = "Detalhes do último " + dtAD.ToString();
        }

        private void FRM_Ad_Load(object sender, EventArgs e)
        {
            //reset your chart series and legends
            chart_ad_status.Series.Clear();
            chart_ad_status.Legends.Clear();
            chart_ad_status.Legends.Add("Computadores");

            //Add a new chart-series
            string MTZ = "MTZ";
            string SMT = "SMT";
            string NTB = "NTB";
            string DSK = "DSK";
            string SVM = "SVM";
            chart_ad_status.Series.Add(MTZ);
            chart_ad_status.Series.Add(SMT);
            chart_ad_status.Series.Add(NTB);
            chart_ad_status.Series.Add(DSK);
            chart_ad_status.Series.Add(SVM);

            chart_ad_status.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart_ad_status.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisX.LineColor = Color.White;

            chart_ad_status.ChartAreas[0].AxisY.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            int MTZ_VALUE = 0;
            int SMT_VALUE = 0;
            int NTB_VALUE = 0;
            int DSK_VALUE = 0;
            int SVM_VALUE = 0;

            foreach (ADInfo comp in AdHelper.AD)
            {
                if(comp != null && comp.CN != null)
                {
                    if (comp.CN.ToUpper().Contains(MTZ)) MTZ_VALUE++;
                    else if (comp.CN.ToUpper().Contains(SMT)) SMT_VALUE++;
                    else if (comp.CN.ToUpper().Contains(NTB)) NTB_VALUE++;
                    else if (comp.CN.ToUpper().Contains(DSK)) DSK_VALUE++;
                    else if (comp.CN.ToUpper().Contains(SVM)) SVM_VALUE++;
                }
            }

            chart_ad_status.Series[MTZ].Points.AddY(MTZ_VALUE);
            chart_ad_status.Series[SMT].Points.AddY(SMT_VALUE);
            chart_ad_status.Series[NTB].Points.AddY(NTB_VALUE);
            chart_ad_status.Series[DSK].Points.AddY(DSK_VALUE);
            chart_ad_status.Series[SVM].Points.AddY(SVM_VALUE);
        }

        private void btn_new_computer_Click(object sender, EventArgs e)
        {
            FRM_newComp frm_newComp = new FRM_newComp();
            frm_newComp.Show();
        }

        private void btn_search_ad_Click(object sender, EventArgs e)
        {
            FRM_AD_Search frm_search = new FRM_AD_Search();
            frm_search.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            FRM_AD_Remove frm_delete = new FRM_AD_Remove();
            frm_delete.Show();
        }

        private void btn_move_ad_Click(object sender, EventArgs e)
        {
            FRM_AD_Move frm_move = new FRM_AD_Move();
            frm_move.Show();
        }
    }
}

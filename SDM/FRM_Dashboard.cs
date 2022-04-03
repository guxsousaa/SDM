using SDM.FRMs_TiEmprest;
using SDM.FRMs_TiEmprest.Dialogs;
using SDM.Methods;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_Dashboard : Form
    {
        public FRM_Dashboard()
        {
            InitializeComponent();
        }

        private void FRM_Dashboard_Load(object sender, EventArgs e)
        {
            //reset your chart series and legends
            chart_ad_status.Series.Clear();
            chart_ad_status.Legends.Clear();
            chart_ad_status.Legends.Add("Computers");

            //Add a new chart-series
            string MTZNTB = "MTZNTB";
            string TIEMPREST = "TIEMPREST";
            string Bloked = "Bloked";
            string Relocation = "Relocation";
            chart_ad_status.Series.Add(MTZNTB);
            chart_ad_status.Series.Add(TIEMPREST);
            chart_ad_status.Series.Add(Bloked);
            chart_ad_status.Series.Add(Relocation);

            chart_ad_status.ChartAreas[0].AxisX.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart_ad_status.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chart_ad_status.ChartAreas[0].AxisY.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            long[] statusResult = AdHelper.getStatus();

            chart_ad_status.Series[MTZNTB].Points.AddXY("MTZNTB", statusResult[0]);
            chart_ad_status.Series[TIEMPREST].Points.AddXY("TIEMPREST", statusResult[1]);
            chart_ad_status.Series[Bloked].Points.AddXY("Bloked", statusResult[2]);
            chart_ad_status.Series[Relocation].Points.AddXY("Relocation", statusResult[3]);
        }

        private void btn_notify_loan_Click(object sender, EventArgs e)
        {
            new FRM_Notify_Options().ShowDialog();
        }
    }
}

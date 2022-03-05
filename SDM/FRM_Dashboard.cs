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
            string seriesname = "Computers";
            chart_ad_status.Series.Add(seriesname);

            //set the chart-type to "Column"
            chart_ad_status.Series[seriesname].ChartType = SeriesChartType.Column;
            chart_ad_status.ChartAreas[0].AxisX.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chart_ad_status.ChartAreas[0].AxisY.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart_ad_status.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            long[] statusResult = AdHelper.getStatus();

            chart_ad_status.Series[seriesname].Points.AddXY("MTZNTB", statusResult[0]);
            chart_ad_status.Series[seriesname].Points.AddXY("TIEMPREST", statusResult[1]);
            chart_ad_status.Series[seriesname].Points.AddXY("Bloked", statusResult[2]);
            chart_ad_status.Series[seriesname].Points.AddXY("Relocation", statusResult[3]);
        }
    }
}

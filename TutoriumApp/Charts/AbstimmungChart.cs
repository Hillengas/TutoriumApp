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
using TutoriumApp.Parameter;

namespace TutoriumApp.Charts
{
    public partial class AbstimmungChart : Form
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }


        public AbstimmungChart()
        {
            InitializeComponent();
            pollChart.Titles.Add("Abstimmung der Online Frage");
        }

        public void FillValuesToChart()
        {
            pollChart.Series["Anzahl"].Points.AddXY("A", A);
            pollChart.Series["Anzahl"].Points.AddXY("B", B);
            pollChart.Series["Anzahl"].Points.AddXY("C", C);
            pollChart.Series["Anzahl"].Points.AddXY("D", D);
            pollChart.Series["Anzahl"].Points.AddXY("E", E);
        }

        /*
            var original = chart1.Series.Add("Original");
            var modified = chart1.Series.Add("Modified");
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            original.Points.AddXY("CPU", 7.6);
            modified.Points.AddXY("CPU", 1.6);
            */


    }
}

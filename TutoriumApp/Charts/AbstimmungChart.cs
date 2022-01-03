using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public int F { get; set; } 

        public double A_p { get; set; }
        public double B_p { get; set; }
        public double C_p { get; set; }
        public double D_p { get; set; }
        public double E_p { get; set; }
        public double F_p { get; set; }


        public AbstimmungChart()
        {
            InitializeComponent();

            var title = pollChart.Titles.Add("Abstimmung der Online Frage");
            var titleP = pollChart_Percent.Titles.Add("Abstimmung der Online Frage (in Prozent)");
            title.ForeColor = Color.White;
            titleP.ForeColor = Color.White;

            pollChart.ChartAreas[0].AxisX.LineColor = Color.White;
            pollChart.ChartAreas[0].AxisY.LineColor = Color.White;
            pollChart.ChartAreas[0].AxisX.InterlacedColor = Color.White;
            pollChart.ChartAreas[0].AxisY.InterlacedColor = Color.White;
            pollChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            pollChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            pollChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            pollChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            pollChart_Percent.ChartAreas[0].AxisX.LineColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisY.LineColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisX.InterlacedColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisY.InterlacedColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            pollChart_Percent.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        public void FillValuesToChart(int anzahl)
        {
            PropertyInfo[] properties = typeof(AbstimmungChart).GetProperties();
            var propertiesList = properties.ToList().Take(anzahl).ToList();
            var propertiesListPercent = properties.ToList().Skip(6).Take(anzahl).ToList();

            char chartCharacter = 'A';
            for (int i = 0; i < anzahl; i++)
            {
                pollChart.Series["Anzahl"].Points.AddXY(chartCharacter.ToString(), propertiesList[i].GetValue(this));
                pollChart_Percent.Series["Prozent"].Points.AddXY(chartCharacter.ToString(), propertiesListPercent[i].GetValue(this));
                chartCharacter++;
            }

            //pollChart_Percent.Series["Prozent"].IsValueShownAsLabel = true;
        }

        private void rjToggleButtonAbstimmungTable_CheckedChanged(object sender, EventArgs e)
        {

            pollChart_Percent.Visible = !pollChart_Percent.Visible;
            pollChart.Visible = !pollChart.Visible;
        }
    }
}

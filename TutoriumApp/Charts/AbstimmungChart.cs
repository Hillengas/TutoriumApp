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
            pollChart.Titles.Add("Abstimmung der Online Frage");
            pollChart_Percent.Titles.Add("Abstimmung der Online Frage (in Prozent)");
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

            /*
            // anzahl
            pollChart.Series["Anzahl"].Points.AddXY("A", A);
            pollChart.Series["Anzahl"].Points.AddXY("B", B);
            pollChart.Series["Anzahl"].Points.AddXY("C", C);
            pollChart.Series["Anzahl"].Points.AddXY("D", D);
            pollChart.Series["Anzahl"].Points.AddXY("E", E);

            //pollChart.Series["Anzahl"].IsValueShownAsLabel = true;

            // prozentual
            pollChart_Percent.Series["Prozent"].Points.AddXY("A", A_p);
            pollChart_Percent.Series["Prozent"].Points.AddXY("B", B_p);
            pollChart_Percent.Series["Prozent"].Points.AddXY("C", C_p);
            pollChart_Percent.Series["Prozent"].Points.AddXY("D", D_p);
            pollChart_Percent.Series["Prozent"].Points.AddXY("E", E_p);
            */

            //pollChart_Percent.Series["Prozent"].IsValueShownAsLabel = true;
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

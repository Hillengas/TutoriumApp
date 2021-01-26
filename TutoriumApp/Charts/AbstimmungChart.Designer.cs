namespace TutoriumApp.Charts
{
    partial class AbstimmungChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pollChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pollChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pollChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pollChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pollChart.Legends.Add(legend1);
            this.pollChart.Location = new System.Drawing.Point(22, 44);
            this.pollChart.Name = "pollChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Anzahl";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.pollChart.Series.Add(series1);
            this.pollChart.Size = new System.Drawing.Size(732, 373);
            this.pollChart.TabIndex = 0;
            this.pollChart.Text = "pollChart";
            // 
            // AbstimmungChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pollChart);
            this.Name = "AbstimmungChart";
            this.Text = "Abstimmung Tabelle";
            ((System.ComponentModel.ISupportInitialize)(this.pollChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pollChart;
    }
}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbstimmungChart));
            this.pollChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pollChart_Percent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rjToggleButtonAbstimmungTable = new TutoriumApp.Helper.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pollChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollChart_Percent)).BeginInit();
            this.SuspendLayout();
            // 
            // pollChart
            // 
            this.pollChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.pollChart.ChartAreas.Add(chartArea1);
            this.pollChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.pollChart.Legends.Add(legend1);
            this.pollChart.Location = new System.Drawing.Point(12, 12);
            this.pollChart.Name = "pollChart";
            this.pollChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.pollChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Anzahl";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.pollChart.Series.Add(series1);
            this.pollChart.Size = new System.Drawing.Size(472, 373);
            this.pollChart.TabIndex = 0;
            this.pollChart.Text = "pollChart";
            // 
            // pollChart_Percent
            // 
            this.pollChart_Percent.BackColor = System.Drawing.Color.Transparent;
            this.pollChart_Percent.BorderlineColor = System.Drawing.Color.Transparent;
            this.pollChart_Percent.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.pollChart_Percent.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.pollChart_Percent.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.pollChart_Percent.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pollChart_Percent.Legends.Add(legend2);
            this.pollChart_Percent.Location = new System.Drawing.Point(12, 100);
            this.pollChart_Percent.Margin = new System.Windows.Forms.Padding(2);
            this.pollChart_Percent.Name = "pollChart_Percent";
            this.pollChart_Percent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.pollChart_Percent.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Orange};
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Prozent";
            series2.Name = "Prozent";
            this.pollChart_Percent.Series.Add(series2);
            this.pollChart_Percent.Size = new System.Drawing.Size(471, 373);
            this.pollChart_Percent.TabIndex = 1;
            this.pollChart_Percent.Text = "pollChart_Percent";
            this.pollChart_Percent.Visible = false;
            // 
            // rjToggleButtonAbstimmungTable
            // 
            this.rjToggleButtonAbstimmungTable.AutoSize = true;
            this.rjToggleButtonAbstimmungTable.Location = new System.Drawing.Point(438, 391);
            this.rjToggleButtonAbstimmungTable.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButtonAbstimmungTable.Name = "rjToggleButtonAbstimmungTable";
            this.rjToggleButtonAbstimmungTable.OffBackColor = System.Drawing.Color.Blue;
            this.rjToggleButtonAbstimmungTable.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButtonAbstimmungTable.OnBackColor = System.Drawing.Color.Orange;
            this.rjToggleButtonAbstimmungTable.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButtonAbstimmungTable.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButtonAbstimmungTable.TabIndex = 2;
            this.rjToggleButtonAbstimmungTable.UseVisualStyleBackColor = true;
            this.rjToggleButtonAbstimmungTable.CheckedChanged += new System.EventHandler(this.rjToggleButtonAbstimmungTable_CheckedChanged);
            // 
            // AbstimmungChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(495, 423);
            this.Controls.Add(this.rjToggleButtonAbstimmungTable);
            this.Controls.Add(this.pollChart_Percent);
            this.Controls.Add(this.pollChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbstimmungChart";
            this.Text = "Abstimmung Tabelle";
            ((System.ComponentModel.ISupportInitialize)(this.pollChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollChart_Percent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pollChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pollChart_Percent;
        private Helper.RJToggleButton rjToggleButtonAbstimmungTable;
    }
}
namespace pasta
{
    partial class chart_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.ComboBox();
            this.end_date = new System.Windows.Forms.ComboBox();
            this.area_combo = new System.Windows.Forms.ComboBox();
            this.display = new System.Windows.Forms.Button();
            this.area_error = new System.Windows.Forms.Label();
            this.start_error = new System.Windows.Forms.Label();
            this.end_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "End date :";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(199, 105);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(387, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select area :";
            // 
            // start_date
            // 
            this.start_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.start_date.FormattingEnabled = true;
            this.start_date.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octobor",
            "November",
            "December"});
            this.start_date.Location = new System.Drawing.Point(119, 68);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(121, 21);
            this.start_date.TabIndex = 7;
            // 
            // end_date
            // 
            this.end_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.end_date.FormattingEnabled = true;
            this.end_date.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octobor",
            "November",
            "December"});
            this.end_date.Location = new System.Drawing.Point(579, 64);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(121, 21);
            this.end_date.TabIndex = 8;
            // 
            // area_combo
            // 
            this.area_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_combo.FormattingEnabled = true;
            this.area_combo.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.area_combo.Location = new System.Drawing.Point(364, 22);
            this.area_combo.Name = "area_combo";
            this.area_combo.Size = new System.Drawing.Size(121, 21);
            this.area_combo.TabIndex = 9;
            // 
            // display
            // 
            this.display.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.display.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.display.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(315, 421);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(124, 44);
            this.display.TabIndex = 10;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // area_error
            // 
            this.area_error.AutoSize = true;
            this.area_error.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.area_error.Location = new System.Drawing.Point(500, 27);
            this.area_error.Name = "area_error";
            this.area_error.Size = new System.Drawing.Size(0, 16);
            this.area_error.TabIndex = 32;
            // 
            // start_error
            // 
            this.start_error.AutoSize = true;
            this.start_error.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.start_error.Location = new System.Drawing.Point(41, 88);
            this.start_error.Name = "start_error";
            this.start_error.Size = new System.Drawing.Size(0, 16);
            this.start_error.TabIndex = 32;
            // 
            // end_error
            // 
            this.end_error.AutoSize = true;
            this.end_error.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.end_error.Location = new System.Drawing.Point(636, 88);
            this.end_error.Name = "end_error";
            this.end_error.Size = new System.Drawing.Size(0, 16);
            this.end_error.TabIndex = 32;
            // 
            // chart_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.end_error);
            this.Controls.Add(this.start_error);
            this.Controls.Add(this.area_error);
            this.Controls.Add(this.display);
            this.Controls.Add(this.area_combo);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "chart_control";
            this.Size = new System.Drawing.Size(862, 512);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox start_date;
        private System.Windows.Forms.ComboBox end_date;
        private System.Windows.Forms.ComboBox area_combo;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label area_error;
        private System.Windows.Forms.Label start_error;
        private System.Windows.Forms.Label end_error;
    }
}

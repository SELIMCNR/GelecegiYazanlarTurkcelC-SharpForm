namespace Digeraraclar
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn_artir = new System.Windows.Forms.Button();
            this.Btn_azalt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Prgsbar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prgsbar3 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Prgsbar4 = new System.Windows.Forms.ProgressBar();
            this.Btn_baslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(12, 42);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Bolge";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(343, 122);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Btn_artir
            // 
            this.Btn_artir.Location = new System.Drawing.Point(426, 42);
            this.Btn_artir.Name = "Btn_artir";
            this.Btn_artir.Size = new System.Drawing.Size(75, 23);
            this.Btn_artir.TabIndex = 1;
            this.Btn_artir.Text = "Artır";
            this.Btn_artir.UseVisualStyleBackColor = true;
            this.Btn_artir.Click += new System.EventHandler(this.Btn_artir_Click);
            // 
            // Btn_azalt
            // 
            this.Btn_azalt.Location = new System.Drawing.Point(426, 84);
            this.Btn_azalt.Name = "Btn_azalt";
            this.Btn_azalt.Size = new System.Drawing.Size(75, 23);
            this.Btn_azalt.TabIndex = 2;
            this.Btn_azalt.Text = "Azalt";
            this.Btn_azalt.UseVisualStyleBackColor = true;
            this.Btn_azalt.Click += new System.EventHandler(this.Btn_azalt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 210);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 60;
            // 
            // Prgsbar2
            // 
            this.Prgsbar2.Location = new System.Drawing.Point(114, 249);
            this.Prgsbar2.Name = "Prgsbar2";
            this.Prgsbar2.Size = new System.Drawing.Size(241, 23);
            this.Prgsbar2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "İşlem 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "İşlem 2:";
            // 
            // Prgsbar3
            // 
            this.Prgsbar3.Location = new System.Drawing.Point(114, 278);
            this.Prgsbar3.Name = "Prgsbar3";
            this.Prgsbar3.Size = new System.Drawing.Size(241, 23);
            this.Prgsbar3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşlem 3:";
            // 
            // Prgsbar4
            // 
            this.Prgsbar4.Location = new System.Drawing.Point(114, 307);
            this.Prgsbar4.Name = "Prgsbar4";
            this.Prgsbar4.Size = new System.Drawing.Size(241, 23);
            this.Prgsbar4.TabIndex = 8;
            // 
            // Btn_baslat
            // 
            this.Btn_baslat.Location = new System.Drawing.Point(391, 246);
            this.Btn_baslat.Name = "Btn_baslat";
            this.Btn_baslat.Size = new System.Drawing.Size(75, 23);
            this.Btn_baslat.TabIndex = 10;
            this.Btn_baslat.Text = "Başlat";
            this.Btn_baslat.UseVisualStyleBackColor = true;
            this.Btn_baslat.Click += new System.EventHandler(this.Btn_baslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_baslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prgsbar4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prgsbar3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prgsbar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_azalt);
            this.Controls.Add(this.Btn_artir);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Btn_artir;
        private System.Windows.Forms.Button Btn_azalt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar Prgsbar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Prgsbar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Prgsbar4;
        private System.Windows.Forms.Button Btn_baslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
    }
}
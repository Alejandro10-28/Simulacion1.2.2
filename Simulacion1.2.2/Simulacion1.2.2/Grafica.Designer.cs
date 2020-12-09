namespace Simulacion1._2._2
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlarriba = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbcRestaurar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pntablero = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.GraficaT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlarriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pntablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlarriba
            // 
            this.pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.pnlarriba.Controls.Add(this.pictureBox2);
            this.pnlarriba.Controls.Add(this.pictureBox1);
            this.pnlarriba.Controls.Add(this.pbcRestaurar);
            this.pnlarriba.Controls.Add(this.pbxCerrar);
            this.pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.pnlarriba.Name = "pnlarriba";
            this.pnlarriba.Size = new System.Drawing.Size(723, 40);
            this.pnlarriba.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::Simulacion1._2._2.Properties.Resources.volver;
            this.pictureBox1.Location = new System.Drawing.Point(-141, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbcRestaurar
            // 
            this.pbcRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcRestaurar.Image = global::Simulacion1._2._2.Properties.Resources.minimizar__3_;
            this.pbcRestaurar.Location = new System.Drawing.Point(643, 4);
            this.pbcRestaurar.Name = "pbcRestaurar";
            this.pbcRestaurar.Size = new System.Drawing.Size(31, 30);
            this.pbcRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcRestaurar.TabIndex = 2;
            this.pbcRestaurar.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.Image = global::Simulacion1._2._2.Properties.Resources.cerrar__2_;
            this.pbxCerrar.Location = new System.Drawing.Point(680, 3);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(31, 30);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 0;
            this.pbxCerrar.TabStop = false;
            // 
            // pntablero
            // 
            this.pntablero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(156)))));
            this.pntablero.Controls.Add(this.bunifuCustomLabel6);
            this.pntablero.Controls.Add(this.GraficaT);
            this.pntablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pntablero.Location = new System.Drawing.Point(0, 40);
            this.pntablero.Name = "pntablero";
            this.pntablero.Size = new System.Drawing.Size(723, 410);
            this.pntablero.TabIndex = 59;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(259, 23);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(243, 18);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "DISTRIBUCIÓN TRIANGULAR";
            // 
            // GraficaT
            // 
            this.GraficaT.BackColor = System.Drawing.Color.Transparent;
            this.GraficaT.BorderlineWidth = 0;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.GraficaT.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.GraficaT.Legends.Add(legend2);
            this.GraficaT.Location = new System.Drawing.Point(3, 75);
            this.GraficaT.Name = "GraficaT";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "ChartLine";
            this.GraficaT.Series.Add(series2);
            this.GraficaT.Size = new System.Drawing.Size(717, 332);
            this.GraficaT.TabIndex = 0;
            this.GraficaT.Text = "chart1";
            this.GraficaT.Click += new System.EventHandler(this.GraficaT_Click);
            // 
            // Time1
            // 
            this.Time1.Enabled = true;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = global::Simulacion1._2._2.Properties.Resources.volver;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.pntablero);
            this.Controls.Add(this.pnlarriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.pnlarriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pntablero.ResumeLayout(false);
            this.pntablero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlarriba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbcRestaurar;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel pntablero;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaT;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Timer Time1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
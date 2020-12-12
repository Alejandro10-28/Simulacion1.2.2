using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion1._2._2
{
    public partial class Grafica : Form
    {
        double minimo,promedio,maximo;
        public Grafica(double min,double prom,double max)
        {
            
            InitializeComponent();
            minimo = min;
            promedio = prom;
            maximo = max;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Time1_Tick(object sender, EventArgs e)
        {
            Time1.Stop();
            double h =( 2 / (promedio - minimo))*(100);
            this.GraficaT.Series["ChartLine"].Points.AddXY(minimo,0);
            this.GraficaT.Series["ChartLine"].Points.AddXY(promedio,h);
            this.GraficaT.Series["ChartLine"].Points.AddXY(maximo,0);
        
        }

        private void GraficaT_Click(object sender, EventArgs e)
        {

        }
    }
}

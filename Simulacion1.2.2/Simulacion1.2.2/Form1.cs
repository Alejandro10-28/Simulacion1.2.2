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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {
            try
            {
                int x0, A, C, M, n;

                n = int.Parse(txtCantidad.Text);
                float[] arr = new float[n];
                x0 = int.Parse(txtX.Text);
                A = int.Parse(txta.Text);
                C = int.Parse(txtc.Text);
                M = int.Parse(txtm.Text);

                for (int i = 0; i < n; i++)
                {
                    int r = dgvPseudoaleatorio.Rows.Add();

                    dgvPseudoaleatorio.Rows[r].Cells[0].Value = i + 1;

                    float aux = (x0 * A + C);
                    float most = x0 * A;
                    dgvPseudoaleatorio.Rows[r].Cells[3].Value = aux;
                    dgvPseudoaleatorio.Rows[r].Cells[4].Value = most;

                    aux %= M;
                    aux = aux / M;
                    arr[i] = aux;
                    x0 = Convert.ToInt32(aux * M);

                    dgvPseudoaleatorio.Rows[r].Cells[1].Value = aux.ToString();
                    dgvPseudoaleatorio.Rows[r].Cells[2].Value = i.ToString() + "--" + x0.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnCalcu_Click(object sender, EventArgs e)
        {
            try
            {
                double relacion = 0;
                int v = 0;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];
                double[] lis2 = new double[dgvPseudoaleatorio.RowCount];

                relacion = (Convert.ToDouble(txtPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text)) / (Convert.ToDouble(txtMaximo.Text) - Convert.ToDouble(txtValorMinimo.Text));
                txtRelacion.Text = relacion.ToString();
                v = int.Parse(txtV1.Text);

                for (int x = 0; x < 21; x++)
                {
                    int r = dgvDistribucionTriangular.Rows.Add();
                    dgvDistribucionTriangular.Rows[r].Cells[0].Value = x;

                    dgvDistribucionTriangular.Rows[r].Cells[1].Value = dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value;
                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value);
                    lis2[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v].Cells[1].Value);
                    dgvDistribucionTriangular.Rows[r].Cells[3].Value = lis1[x];
                    dgvDistribucionTriangular.Rows[r].Cells[4].Value = lis2[x];

                    if (lis1[x] > relacion)
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[2].Value = ((Convert.ToDouble(txtMaximo.Text) - ((Convert.ToDouble(txtMaximo.Text) - Convert.ToDouble(txtPromedio.Text))) * (Math.Sqrt(1 - lis2[x]))));

                    }
                    else
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[2].Value = ((Convert.ToDouble(txtValorMinimo.Text) + ((Convert.ToDouble(txtPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text))) * (Math.Sqrt(lis2[x]))));

                    }
                    v++;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double min = Convert.ToDouble(txtValorMinimo.Text);
                double prom = Convert.ToDouble(txtPromedio.Text);
                double max = Convert.ToDouble(txtMaximo.Text);
                Grafica grafica = new Grafica(min, prom, max);

                grafica.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbcRestaurar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Ejercicio : Form
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {
            Generador();
        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void BtnUniforme_Click(object sender, EventArgs e)
        {
            try
            {
                int v = 0;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];
                double a = Convert.ToDouble(txtValorMinimo.Text);
                double b = Convert.ToDouble(txtMaximo.Text);
                double InicioJornada = Convert.ToDouble(txtInicioJornada.Text);
                v = int.Parse(txtV1.Text);

                for (int x = 0; x < 21; x++)
                {
                    int r = dgvUniforme.Rows.Add();
                    dgvUniforme.Rows[r].Cells[0].Value = x;

                    dgvUniforme.Rows[r].Cells[1].Value = dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value;
                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value);
                    
                    dgvUniforme.Rows[r].Cells[1].Value = lis1[x];
                    dgvUniforme.Rows[r].Cells[2].Value = a +((b-a)* Convert.ToDouble(dgvUniforme.Rows[r].Cells[1].Value));
                    if (x == 0)
                    {
                        dgvUniforme.Rows[r].Cells[3].Value = InicioJornada + Convert.ToDouble(dgvUniforme.Rows[x].Cells[2].Value);


                    }
                    else
                    {
                        dgvUniforme.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x-1].Cells[3].Value)+ Convert.ToDouble(dgvUniforme.Rows[x].Cells[2].Value);

                    }
                    //dgvUniforme.Rows[r].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[r].Cells[3].Value);
                    //dgvUniforme.Rows[r].Cells[5].Value = Convert.ToDouble(dgvUniforme.Rows[r].Cells[4].Value) - Convert.ToDouble(dgvUniforme.Rows[r].Cells[3].Value);

                    v++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnCalcu_Click(object sender, EventArgs e)
        {
            double relacion = 0, prom = 0;

            try
            {
                int v = 0;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];

                relacion = (Convert.ToDouble(txtPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text)) / (Convert.ToDouble(txtMaximo.Text) - Convert.ToDouble(txtValorMinimo.Text));
                txtRelacion.Text = relacion.ToString();
                v = int.Parse(txtV1.Text);

                for (int x = 0; x < 21; x++)
                {
                    int r = dgvDistribucionTriangular.Rows.Add();

                   // dgvDistribucionTriangular.Rows[r].Cells[0].Value = dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value;
                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v].Cells[1].Value);
                    dgvDistribucionTriangular.Rows[r].Cells[0].Value = lis1[x];

                    if (lis1[x] > relacion)
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[1].Value = ((Convert.ToDouble(txtMaximo.Text) - ((Convert.ToDouble(txtMaximo.Text) - Convert.ToDouble(txtPromedio.Text))) * (Math.Sqrt(1 - Convert.ToDouble(dgvUniforme.Rows[x].Cells[1].Value)))));

                    }
                    else
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[1].Value = ((Convert.ToDouble(txtValorMinimo.Text) + ((Convert.ToDouble(txtPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text))) * (Math.Sqrt(Convert.ToDouble(dgvUniforme.Rows[x].Cells[1].Value)))));

                    }
                    dgvDistribucionTriangular.Rows[r].Cells[2].Value = Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[1].Value)+Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value);
                    if (x == 0)
                    {
                        dgvUniforme.Rows[x].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[r].Cells[3].Value);
                        // dgvDistribucionTriangular.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(txtInicioJornada.Text);
                        dgvDistribucionTriangular.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(txtInicioJornada.Text);

                    }
                    else
                    {
                        if (Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[2].Value) > Convert.ToDouble(dgvUniforme.Rows[x ].Cells[3].Value))
                        {
                            dgvUniforme.Rows[x ].Cells[4].Value = Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[2].Value);

                        }
                        else
                        {
                            dgvUniforme.Rows[x ].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                        }
                        dgvDistribucionTriangular.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(dgvDistribucionTriangular.Rows[x-1].Cells[2].Value);

                    }
                    dgvUniforme.Rows[x].Cells[5].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                    prom = prom + Convert.ToDouble(dgvUniforme.Rows[x].Cells[5].Value);
                    v++;
                }
               //    prom = prom / 21;
                txtProm.Text = prom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Generador()
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
                    aux %= M;
                    aux = aux / M;
                    arr[i] = aux;
                    x0 = Convert.ToInt32(aux * M);

                    dgvPseudoaleatorio.Rows[r].Cells[1].Value = aux.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

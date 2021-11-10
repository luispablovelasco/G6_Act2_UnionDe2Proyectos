using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejemplo3_4_Ejercicio3_
{
    public partial class Frmareas : Form
    {
        public Frmareas()
        {
            InitializeComponent();
        }

        Figura[] arreglof = new Figura[5]; //Agregamos el arreglo de la clase figura

        private void btncalcularlado_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtlado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(label2);
        }

        private void btncalcularradio_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtradio.Text);
            double A = 0;

            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(label4);
        }

        private void btnarreglo_Click(object sender, EventArgs e)
        {
            //inicialización de variables
            double R = double.Parse(txtarreglo.Text);
            double A = 0;
            double L = double.Parse(txtarreglo.Text);

            /*  Creamos objetos de tipo Figura quye pueden ser cuadrados o circulos. En el parámetro del valor modificamos
                en una unidad para que no se vea en todo el mismo resultado  */

            arreglof[0] = new Cuadrado(A, L);
            arreglof[1] = new Cuadrado(A, L+1);
            arreglof[2] = new Circulo(A, R);
            arreglof[3] = new Circulo(A, R+1);
            arreglof[4] = new Circulo(A, R+2);

            /*  Cada objeto envñia la respuesta a su label correspondiente. El label mostrará el cálculo de acuerdo 
                al objeto que lo invocó  */

            arreglof[0].CalcularArea(label6);
            arreglof[1].CalcularArea(label7);
            arreglof[2].CalcularArea(label8);
            arreglof[3].CalcularArea(label9);
            arreglof[4].CalcularArea(label10);
        }

        private void btncalcularrombo_Click(object sender, EventArgs e)
        {
            double diagomay = double.Parse(txtmay.Text);
            double diagomen = double.Parse(txtmen.Text);
            Rombo rombo = new Rombo(diagomay, diagomen);
            rombo.CalcularArea(label13);
        }

        private void btnmenu2_Click(object sender, EventArgs e)
        {
            G6_UnionDe2Proyectos.FrmMenu menu = new G6_UnionDe2Proyectos.FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void Frmareas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

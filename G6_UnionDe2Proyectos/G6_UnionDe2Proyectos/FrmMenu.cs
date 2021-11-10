using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G6_UnionDe2Proyectos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnareas_Click(object sender, EventArgs e)
        {
            G4_Ejemplo3_4_Ejercicio3_.Frmareas tareas = new G4_Ejemplo3_4_Ejercicio3_.Frmareas();
            tareas.Show();
            this.Hide();
        }

        private void btnnotas_Click(object sender, EventArgs e)
        {
            G3_Ejercicio01.Frmnotas notas = new G3_Ejercicio01.Frmnotas();
            notas.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

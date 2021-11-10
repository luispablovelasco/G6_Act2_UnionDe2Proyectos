using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Ejercicio01
{

    public partial class Frmnotas : Form
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        private int editIndice = -1;

        public float promedio(float nota1, float nota2, float nota3)
        {
            float notapromedio = (nota1 + nota2 + nota3) / 3;
            return notapromedio;
        }

        private void actualizarGrid()
        {
            dgvalumnos.DataSource = null;
            dgvalumnos.DataSource = Alumnos;
        }
        private void limpiar()
        {
            txtapellido.Clear();
            txtcarnet.Clear();
            txtmateria.Clear();
            txtnombre.Clear();
        }
        public Frmnotas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            Alumno alumno = new Alumno();
            alumno.Nombre = txtnombre.Text;
            alumno.Apellido = txtapellido.Text;
            alumno.Carnet = txtcarnet.Text;
            alumno.Materia = txtmateria.Text;
            alumno.Calificaciones[0] = float.Parse(txtnota1.Text);
            alumno.Calificaciones[1] = float.Parse(txtnota2.Text);
            alumno.Calificaciones[2] = float.Parse(txtnota3.Text);

            float notaPromedio = promedio(alumno.Calificaciones[0], alumno.Calificaciones[1], alumno.Calificaciones[2]);

            if (editIndice >-1)
            {
                Alumnos[editIndice] = alumno;
                editIndice = -1;
            }
            else
            {
                Alumnos.Add(alumno);
            }
            actualizarGrid();
            limpiar();

        }

        private void dgvalumnos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvalumnos.SelectedRows[0];
            int pos = dgvalumnos.Rows.IndexOf(seleccion);
            editIndice = pos;

            Alumno listalumno = Alumnos[pos];

            //Lo siguiente es para cuando se seleccione el alumno, nos muestre los datos en los textbox correspondientes
            txtnombre.Text = listalumno.Nombre;
            txtcarnet.Text = listalumno.Apellido;
            txtmateria.Text = listalumno.Materia;
            txtapellido.Text = listalumno.Apellido;
            txtnota1.Text = Convert.ToString(listalumno.Calificaciones[0]);
            txtnota2.Text = Convert.ToString(listalumno.Calificaciones[1]);
            txtnota3.Text = Convert.ToString(listalumno.Calificaciones[2]);

            float notaPromedio = promedio(float.Parse(txtnota1.Text), float.Parse(txtnota2.Text), float.Parse(txtnota3.Text));
 
            txtprom.Text = Convert.ToString(notaPromedio);
            
        }

        private void btnmenu1_Click(object sender, EventArgs e)
        {
            G6_UnionDe2Proyectos.FrmMenu menu = new G6_UnionDe2Proyectos.FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void Frmnotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

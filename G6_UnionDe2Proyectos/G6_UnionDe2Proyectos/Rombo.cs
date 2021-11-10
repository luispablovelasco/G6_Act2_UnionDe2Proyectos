using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejemplo3_4_Ejercicio3_
{
    public class Rombo : Figura
    {
        private double diagonalmay; //Atributos
        private double diagonalmen;

        public Rombo(double may, double men): base(may) //Constructor con parametros
        {
            diagonalmay = may;
            diagonalmen = men;
        }

        //Propiedades
        public double Diagonalmay 
        {
            get { return diagonalmay; }
            set { diagonalmay = value; }
        }

        public double DiagonalMen
        {
            get { return diagonalmen; }
            set { diagonalmen = value; }
        }

        //Método sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (Diagonalmay * DiagonalMen) / 2;
            LR.Text = "Area: " + Area;
        }

    }
}

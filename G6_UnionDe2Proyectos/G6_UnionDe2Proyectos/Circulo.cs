using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejemplo3_4_Ejercicio3_
{
     public class Circulo : Figura //Clase hereda de Figura
    {
        private double radio; //Atributo
        
        public Circulo(double A, double R): base(A)//Constructor con parametros
        {
            radio = R;
        }

        public double Radio //Propiedad
        {
            get { return radio; }
            set { radio = value; }
        }

        //Método sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            LR.Text = "Area: " + Area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejemplo3_4_Ejercicio3_
{
    public class Cuadrado : Figura //Clase hereda de Figura
    {
        private double lado;

        public Cuadrado(double A, double L) : base(A) //Constructor
        {
            lado = L;
        }

        public double Lado //Propiedad
        {
            get { return lado; }
            set { lado = value; }
        }

        //Método sobreescrito
        public override void CalcularArea(Label LR) 
        {
            Area = (Lado * Lado);
            LR.Text = "Area " + Area;
        }
        /*
            Override: Permite a las clases derivadas sobreescribir las instrucciones de método que fueron definidas en la clase
            base. Con ello podrá realizar su propia instruccioón pero manteniendo el mismo nombre.        
        */
    }
}

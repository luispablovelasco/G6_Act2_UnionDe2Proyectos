using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Agregamos esta librería

namespace G4_Ejemplo3_4_Ejercicio3_
{
    public abstract class Figura //Clase pública que no permite instancias
    {
        private double area; //Atributo

        //Constructor
        public Figura (double A)
        {
            area = A;
        }

        //Propiedad
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        //Método utilizando virtual
        public virtual void CalcularArea(Label LR)
        {

        }
    }
}

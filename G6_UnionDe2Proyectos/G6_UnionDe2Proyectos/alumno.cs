using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Ejercicio01
{
    class Alumno
    {
        //Atributos
        string carnet;
        string nombre;
        string apellido;
        string materia;
        float[] calificaciones = new float[3];
        

        //Metodos
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public float[] Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }


    }
}

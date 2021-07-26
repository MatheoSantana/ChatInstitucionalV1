using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Clase
    {
        private int anio;
        private Orientacion orientacion;
        private string nombre;

        public Clase()
        {

        }
        public Clase(int anio, Orientacion orientacion, string nombre)
        {
            this.anio = anio;
            this.orientacion = orientacion;
            this.nombre = nombre;
        }

        public int Anio
        {
            set { anio = value; }
            get { return anio; }
        }

        public Orientacion Orientacion
        {
            set { orientacion = value; }
            get { return orientacion; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        override
        public string ToString()
        {
            return anio + nombre + " - " + orientacion;
        }
    }
}

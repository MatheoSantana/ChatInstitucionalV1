using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Chat_institucional
{
    public class Orientacion
    {
        private string nombre;

        public Orientacion()
        {
        }
        public Orientacion(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

    }
}

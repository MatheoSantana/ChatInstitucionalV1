using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Asignatura
    {
        private string id;
        private string nombre;
        private int anio;

        public Asignatura()
        {

        }
        public Asignatura(string id, string nombre, int anio)
        {
            this.id = id;
            this.nombre = nombre;
            this.anio = anio;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        override
        public string ToString()
        {
            return nombre +anio +" - " + id;
        }
    }
}

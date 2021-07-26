using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Cursa
    {
        private Clase clase;
        private Alumno alumno;
        private Asignatura asignatura;

        public Cursa()
        {

        }

        public Cursa(Clase clase, Alumno alumno, Asignatura asignatura)
        {
            this.asignatura = asignatura;
            this.clase = clase;
            this.alumno = alumno;
        }
        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
        public Clase Clase
        {
            get { return clase; }
            set { clase = value; }
        }
    }
}

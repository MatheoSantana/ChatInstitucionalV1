using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Dicta
    {
        private Clase clase;
        private Docente docente;
        private Asignatura asignatura;

        public Dicta()
        {

        }

        public Dicta(Clase clase, Docente docente, Asignatura asignatura)
        {
            this.asignatura = asignatura;
            this.clase = clase;
            this.docente = docente;
        }
        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public Clase Clase
        {
            get { return clase; }
            set { clase = value; }
        }
    }
}

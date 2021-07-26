using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Contiene
    {
        private Asignatura asignatura;
        private Orientacion orientacion;

        public Contiene()
        {

        }
        public Contiene(Asignatura asignatura, Orientacion orientacion)
        {
            this.orientacion = orientacion;
            this.asignatura = asignatura;
        }

        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public Orientacion Orientacion
        {
            get { return orientacion; }
            set { orientacion = value; }
        }
    
    }

}

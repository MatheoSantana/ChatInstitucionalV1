using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Contesta
    {
        private Alumno alumno;
        private Docente docente;
        private DateTime fechaHoraAlumno;
        private string mensajeDocente;
        private DateTime fechaHoraDocente;
        public Contesta()
        {

        }
        public Contesta(Alumno alumno, Docente docente, DateTime fechaHoraAlumno, string mensajeDocente, DateTime fechaHoraDocente)
        {
            this.alumno = alumno;
            this.docente = docente;
            this.fechaHoraAlumno = fechaHoraAlumno;
            this.mensajeDocente = mensajeDocente;
            this.fechaHoraDocente = fechaHoraDocente;
        }
        public Alumno Alumno
        {
            set { alumno = value; }
            get { return alumno; }
        }
        public Docente Docente
        {
            set { docente = value; }
            get { return docente; }
        }
        public DateTime FechaHoraAlumno
        {
            set { fechaHoraAlumno = value; }
            get { return fechaHoraAlumno; }
        }
        public string MensajeDocente
        {
            set { mensajeDocente = value; }
            get { return mensajeDocente; }
        }
        public DateTime FechaHoraDocente
        {
            set { fechaHoraDocente = value; }
            get { return fechaHoraDocente; }
        }
    }
}

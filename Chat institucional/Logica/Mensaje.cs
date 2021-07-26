using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class Mensaje
    {
        private Alumno alumno;
        private Docente docente;
        private DateTime fechaHoraAlumno;
        private string mensajeAlumno;
        private string estado;
        private string asunto;
        public Mensaje()
        {

        }
        public Mensaje(Alumno alumno, string asunto, DateTime fechaHoraAlumno, string mensajeAlumno, Docente docente, string estado)
        {
            this.alumno = alumno;
            this.asunto = asunto;
            this.fechaHoraAlumno = fechaHoraAlumno;
            this.mensajeAlumno = mensajeAlumno;
            this.docente = docente;
            this.estado = estado;
        }
        public Alumno Alumno
        {
            set { alumno = value; }
            get { return alumno; }
        }

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }
        public DateTime FechaHoraAlumno
        {
            set { fechaHoraAlumno = value; }
            get { return fechaHoraAlumno; }
        }
        public string MensajeAlumno
        {
            set { mensajeAlumno = value; }
            get { return mensajeAlumno; }
        }
        public Docente Docente
        {
            set { docente = value; }
            get { return docente; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
    }
}

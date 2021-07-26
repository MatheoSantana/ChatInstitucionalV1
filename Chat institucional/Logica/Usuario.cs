using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Chat_institucional
{
    public class Usuario
    {
        private string ci;
        private string password;
        private string nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private Image fotoDePerfil;
        private string apodo;
        private PreguntaSeg pregunta_seguridad;
        private string respuesta_seguridad;
        public Usuario()
        {
        }
        public Usuario(string ci, string password, string nombre, string primer_apellido, string segundo_apellido, Image fotoDePerfil, string apodo, PreguntaSeg pregunta_seguridad, string respuesta_seguridad)
        {
            this.ci = ci;
            this.password = password;
            this.nombre = nombre;
            this.primer_apellido = primer_apellido;
            this.segundo_apellido = segundo_apellido;
            this.fotoDePerfil = fotoDePerfil;
            this.apodo = apodo;
            this.pregunta_seguridad = pregunta_seguridad;
            this.respuesta_seguridad = respuesta_seguridad;
        }
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value; }
        }
        public string Segundo_apellido
        {
            get { return segundo_apellido; }
            set { segundo_apellido = value; }
        }
        public Image FotoDePerfil
        {
            get { return fotoDePerfil; }
            set { fotoDePerfil = value; }
        }
        public string Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }
        public PreguntaSeg Preguta_seguridad
        {
            get { return pregunta_seguridad; }
            set { pregunta_seguridad = value; }
        }
        public string Respuesta_seguridad
        {
            get { return respuesta_seguridad; }
            set { respuesta_seguridad = value; }
        }

    }
}

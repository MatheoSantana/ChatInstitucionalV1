using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Chat_institucional
{
    public class Administrador : Usuario
    {
        public Administrador()
        {

        }
        public Administrador(string ci, string password, string nombre, string primer_apellido, string segundo_apellido, Image fotoDePerfil, string apodo, PreguntaSeg pregunta_seguridad, string respuesta_seguridad) : base(ci, password, nombre, primer_apellido, segundo_apellido, fotoDePerfil, apodo, pregunta_seguridad, respuesta_seguridad)
        {

        }
    }
}

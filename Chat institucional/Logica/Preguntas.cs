using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_institucional
{
    public class PreguntaSeg
    {
        private int id;
        private string pregunta;

        public PreguntaSeg()
        {

        }
        public PreguntaSeg(int id, string pregunta)
        {
            this.id = id;
            this.pregunta = pregunta;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Pregunta
        {
            set { pregunta = value; }
            get { return pregunta; }
        }
    }
}

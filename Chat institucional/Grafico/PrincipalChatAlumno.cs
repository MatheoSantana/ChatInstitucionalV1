using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_institucional
{
    public partial class PrincipalChatAlumno : Form
    {
        public Form login;
        public Form mensajesAlumno;
        public Form perfilAlumno;
        public PrincipalChatAlumno()
        {
            InitializeComponent();
            Text = "Chat";
            Icon = new Icon(Application.StartupPath + "logo imagen.ico");
            ClientSize = new Size(1280, 720);

            StartPosition = FormStartPosition.CenterScreen;

            //nav
            pbxFotoPerfilNav.Image = Login.encontrado.FotoDePerfil;
            pbxChatNav.Image = Image.FromFile("chat blanco.png");
            pbxMensajeNav.Image = Image.FromFile("mensaje gris.png");
            pbxPerfilNav.Image = Image.FromFile("perfil gris.png");
            pbxGruposNav.Image = Image.FromFile("grupos gris.png");
            pbxHistorialNav.Image = Image.FromFile("historial gris.png");
            pbxCerrarSesionNav.Image = Image.FromFile("cerrar sesion.png");


            pbxFotoPerfilNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxChatNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMensajeNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPerfilNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxGruposNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxHistorialNav.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCerrarSesionNav.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void PrincipalChatAlumno_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            login.Dispose();
        }

        private void pbxMensajeNav_Click(object sender, EventArgs e)
        {

            mensajesAlumno.Show();
            this.Hide();
        }

        private void pbxPerfilNav_Click(object sender, EventArgs e)
        {
            perfilAlumno.Show();
            this.Hide();
        }

        private void pbxGruposNav_Click(object sender, EventArgs e)
        {

        }

        private void pbxCerrarSesionNav_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo);
            if (cerrarSesion == DialogResult.Yes)
            {
                Login.encontrado = null;
                login.Show();
                this.Dispose();
            }
        }


    }
}

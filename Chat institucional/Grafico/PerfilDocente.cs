using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_institucional
{
    public partial class PerfilDocente : Form
    {
        public Form login;
        public Form mensajesDocente;
        public Form principalChatDocente;
        
        public PerfilDocente()
        {
            InitializeComponent();

            Text = "Perfil";
            Icon = new Icon(Application.StartupPath + "logo imagen.ico");
            ClientSize = new Size(1280, 720);

            lblCambiarFoto.ForeColor = Color.Blue;
            lblCambiarFoto.Font = new Font("Arial", 9.0f, FontStyle.Underline);

            StartPosition = FormStartPosition.CenterScreen;

            //nav
            pbxFotoPerfilNav.Image = Login.encontrado.FotoDePerfil;
            pbxChatNav.Image = Image.FromFile("chat gris.png");
            pbxMensajeNav.Image = Image.FromFile("mensaje gris.png");
            pbxPerfilNav.Image = Image.FromFile("perfil blanco.png");
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

            txtPassword.UseSystemPasswordChar = true;

            lblNombre.Text += Login.encontrado.Nombre + " " + Login.encontrado.Primer_apellido + " " + Login.encontrado.Segundo_apellido;
            lblCedula.Text += Login.encontrado.Ci;
            pbxFoto.Image = Login.encontrado.FotoDePerfil;
            pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            txtApodo.Text = Login.encontrado.Apodo;
            txtPassword.Text = Login.encontrado.Password;
            txtPasswordCon.Text = Login.encontrado.Password;
            cbxPregs.DropDownStyle = ComboBoxStyle.DropDownList;
            int x = 0;
            foreach (PreguntaSeg preg in Login.pregs)
            {
                cbxPregs.Items.Add(preg.Pregunta);
                if (Login.encontrado.Preguta_seguridad == preg)
                {
                    cbxPregs.SelectedIndex = x;
                }
                x++;
            }

            txtRespuesta.Text = Login.encontrado.Respuesta_seguridad;

        }

        private void PerfilDocente_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            login.Dispose();
        }

        

        private void pbxChatNav_Click(object sender, EventArgs e)
        {
            principalChatDocente.Show();
            this.Hide();
        }

        private void pbxMensajeNav_Click(object sender, EventArgs e)
        {
            mensajesDocente.Show();
            this.Hide();
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

        private void lblCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();
            ofdFoto.Filter = "Imagenes|*.jpg; *.png; *.jpeg";
            ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdFoto.Title = "Seleccionar imagen";
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(ofdFoto.FileName);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Login.usuarios)
            {
                if (us == Login.encontrado)
                {
                    us.Apodo = txtApodo.Text;
                    us.Password = txtPassword.Text;
                    us.Respuesta_seguridad = txtRespuesta.Text;
                    int y = 0;
                    foreach (PreguntaSeg preg in Login.pregs)
                    {
                        if (cbxPregs.SelectedItem.ToString() == preg.Pregunta)
                        {
                            us.Preguta_seguridad = preg;
                        }
                        y++;
                    }
                    us.FotoDePerfil = pbxFoto.Image;
                    MessageBox.Show("Se cerrará la sesion para recargar los datos");
                    Login.encontrado = null;
                    login.Show();
                    this.Dispose();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Login.usuarios.Remove(Login.encontrado);
            Login.encontrado = null;
            login.Show();
            this.Dispose();
        }
    }
}

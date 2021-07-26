using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chat_institucional
{
    public partial class RegisterDocente : Form
    {
        public Form login;
        public Form register;
        public Form registerClasesDocente;
        public Docente doc = new Docente();

        public RegisterDocente()
        {
            InitializeComponent();

            Text = "Register Docente";
            Icon = new Icon(Application.StartupPath + "logo imagen.ico");
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1280, 720);

            pbxVolver.Image = Image.FromFile("volver.png");
            pbxVolver.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitulo.Text = "Crea tu cuenta de docente";

            cbxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (PreguntaSeg preg in Login.pregs)
            {
                cbxPreguntas.Items.Add(preg.Pregunta);
            }
            cbxPreguntas.SelectedIndex = 0;


            txtPassword.UseSystemPasswordChar=true;
            txtConfirmarPassword.UseSystemPasswordChar = true;
            btnSiguiente.BackColor = Color.FromArgb(242, 144, 97);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.FlatAppearance.BorderSize = 0;

        }

        private void RegisterDocente_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }
        

        private void CerrarForm(object sender, EventArgs e)
        {
            login.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            string error = "Cuidado: ";
            bool aceptable = true;

            if (txtCedula.Text == "" || txtNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtPassword.Text == "" || txtConfirmarPassword.Text == "" || txtRespuesta.Text == "")
            {
                aceptable = false;
                error += "\nDebe rellenar todos los campos";
            }

            if (txtPassword.Text.Length < 8)
            {
                aceptable = false;
                error += "\nLa contraseña es demaciado corta";
            }
            if (txtConfirmarPassword.Text != txtPassword.Text)
            {
                aceptable = false;
                error += "\nLas contraseñas no son iguales";
            }
            foreach (Usuario us in Login.usuarios)
            {
                if (us.Ci.ToString() == txtCedula.Text)
                {
                    aceptable = false;
                    error += "\n\nAdvertencia: esa cedula ya esta ingresada";
                }

            }
            if (!aceptable)
            {
                MessageBox.Show(error);
            }
            else
            {
                doc.Ci = txtCedula.Text;
                doc.Nombre = txtNombre.Text;
                doc.Primer_apellido = txtPrimerApellido.Text;
                doc.Segundo_apellido = txtSegundoApellido.Text;
                doc.Password = txtPassword.Text;
                doc.Preguta_seguridad = Login.pregs[cbxPreguntas.SelectedIndex];
                doc.Respuesta_seguridad = txtRespuesta.Text;
                RegisterClasesDocente registerClasesDocente = new RegisterClasesDocente();
                this.registerClasesDocente = registerClasesDocente;
                registerClasesDocente.registerDocente = this;
                registerClasesDocente.login = login;
                registerClasesDocente.Docente = doc;
                registerClasesDocente.Show();
                this.Hide();
            }




        }

        private void pbxVolver_Click(object sender, EventArgs e)
        {
            register.Show();
            this.Hide();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat_institucional
{
    public partial class Login : Form
    {
        static Register register;

        static PrincipalChatDocente principalChatDocente;
        static MensajesDocente mensajesDocente;
        static PerfilDocente perfilDocente;
        static RegisterDocente registerDocente;

        static PrincipalChatAlumno principalChatAlumno;
        static MensajesAlumno mensajesAlumno;
        static PerfilAlumno perfilAlumno;
        static RegisterAlumno registerAlumno;


        public static List<Clase> clases = new List<Clase>();
        public static List<Asignatura> asignaturas = new List<Asignatura>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Orientacion> orientaciones = new List<Orientacion>();

        public static List<PreguntaSeg> pregs = new List<PreguntaSeg>();

        public static List<Dicta> dictan = new List<Dicta>();
        public static List<Contiene> contienen = new List<Contiene>();
        public static List<Cursa> cursan = new List<Cursa>();

        public static List<Mensaje> mensajes = new List<Mensaje>();
        public static List<Contesta> contestan = new List<Contesta>();

        string usuarioNoEncontrado;
        string contraseñaIncorrecta;

        public static Usuario encontrado = null;

        public static string idioma;
        Font fuenteLink = new Font("Arial", 9.0f, FontStyle.Underline);
        Image fotoEspanol = Image.FromFile("español chiquito.png");
        Image fotoIngles = Image.FromFile("ingles chiquito.png");
        public Login()
        {
            InitializeComponent();

            Text = "Login";
            Icon = new Icon(Application.StartupPath + "logo imagen.ico");
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1280, 720);

            txtPassword.UseSystemPasswordChar = true;
            //inicializamos los controles
            //bloqueamos la edicion del combo box idioma
            cbxIdioma.DropDownStyle = ComboBoxStyle.DropDownList;

            Asignatura a0 = new Asignatura("progds3", "Programacion III", 3);
            Asignatura a1 = new Asignatura("mate3", "Matematica III", 3);
            Asignatura a2 = new Asignatura("bdd2", "Base de datos II", 3);
            Asignatura a3 = new Asignatura("progdw3", "Programacion web", 3);
            Asignatura a4 = new Asignatura("mate1", "Matematica I", 1);
            Asignatura a5 = new Asignatura("progi1", "Programacion I", 1);
            Asignatura a6 = new Asignatura("log", "Logica", 1);

            asignaturas.Add(a0);
            asignaturas.Add(a1);
            asignaturas.Add(a2);
            asignaturas.Add(a3);
            asignaturas.Add(a4);
            asignaturas.Add(a5);
            asignaturas.Add(a6);

            Orientacion o0 = new Orientacion("Desarrollo y soporte");
            Orientacion o1 = new Orientacion("Desarrollo web");

            orientaciones.Add(o0);
            orientaciones.Add(o1);

            contienen.Add(new Contiene(a0, o0));
            contienen.Add(new Contiene(a1, o0));
            contienen.Add(new Contiene(a2, o0));

            contienen.Add(new Contiene(a1, o1));
            contienen.Add(new Contiene(a2, o1));
            contienen.Add(new Contiene(a3, o1));

            PreguntaSeg p0 = new PreguntaSeg(0,"¿Cuál es el nombre de tu primer mascota?");
            PreguntaSeg p1 = new PreguntaSeg(1, "¿En qué calle está ubicado tu primer hogar?");
            PreguntaSeg p2 = new PreguntaSeg(2, "¿Cual es tu sabor de helado favorito?");
            pregs.Add(p0);
            pregs.Add(p1);
            pregs.Add(p2);

            Clase c0 = new Clase(3, o0, "BA");
            Clase c1 = new Clase(3, o1, "BB");

            clases.Add(c0);
            clases.Add(c1);

            Administrador admin = new Administrador("00000000", "L2tpbGwgQG1l", "Administrador", "Del", "Sistema", Image.FromFile("Administrador.png"), "Administrador", p2, "Agua granizada");
            Alumno alu0 = new Alumno("52848682", "matheo1234", "Matheo", "santana", "Honey", Image.FromFile("Alumno.png"), "Palme", p1, "Guayabos");
            Alumno alu1 = new Alumno("52124670", "mauro1234", "Mauro", "Liguori", "Arias", Image.FromFile("Alumno.png"), "Mauro", p0, "Neron");
            Alumno alu2 = new Alumno("51972127", "agustin1234", "Agustin", "Pastorelli", "Do Prado", Image.FromFile("Alumno.png"), "Agustin", p1, "Quichuas");
            Docente doc0 = new Docente("12314542", "12345678", "Jose", "Alvarez", "Gutierrez", Image.FromFile("Docente.png"), "Jose", p2, "coco");
            Docente doc1 = new Docente("29993223", "87654321", "Pedro", "Sanachez", "Guerra", Image.FromFile("Docente.png"), "Pepe", p0, "Trueno");
            Docente doc2 = new Docente("40111234", "11111111", "Alberto", "Santin", "Fierro", Image.FromFile("Docente.png"), "Alber", p0, "Anini");

            cursan.Add(new Cursa(c0, alu0, a0));
            cursan.Add(new Cursa(c0, alu0, a1));
            cursan.Add(new Cursa(c0, alu0, a2));

            cursan.Add(new Cursa(c0, alu1, a0));
            cursan.Add(new Cursa(c0, alu1, a1));
            cursan.Add(new Cursa(c1, alu1, a3));

            cursan.Add(new Cursa(c1, alu2, a3));
            cursan.Add(new Cursa(c1, alu2, a1));
            cursan.Add(new Cursa(c1, alu2, a2));

            dictan.Add(new Dicta(c0, doc0, a2));
            dictan.Add(new Dicta(c1, doc0, a2));

            dictan.Add(new Dicta(c0, doc1, a0));
            dictan.Add(new Dicta(c1, doc1, a3));

            dictan.Add(new Dicta(c0, doc2, a1));
            dictan.Add(new Dicta(c1, doc2, a1));


            usuarios.Add(admin);
            usuarios.Add(alu0);
            usuarios.Add(alu1);
            usuarios.Add(alu2);
            usuarios.Add(doc0);
            usuarios.Add(doc1);
            usuarios.Add(doc2);

            lblCambioPassword.ForeColor = Color.Blue;
            lblCambioPassword.Font = fuenteLink;
            lblRegistrarse.Font = fuenteLink;
            lblRegistrarse.ForeColor = Color.Blue;

            //agregamos los idiomas
            cbxIdioma.Items.Add("Español");
            cbxIdioma.Items.Add("English");

            //seteamos en español el idioma del combo box
            cbxIdioma.SelectedIndex = 0;
            
            lblTitulo.Text = "Inicio de sesion";
            idioma = cbxIdioma.SelectedItem.ToString();
            lblCambioPassword.Visible = false;
            cbxIdioma.Visible = false;
            pbxIdioma.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cbxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdioma.SelectedItem.ToString() == "Español")
            {
                idioma = cbxIdioma.SelectedItem.ToString();
                lblTitulo.Text = "Inicio de sesion";
                lblCedula.Text = "Cédula de identidad";
                lblPassword.Text = "Contraseña";
                pbxIdioma.Image = fotoEspanol;
                btnIniciarSesion.Text = "Iniciar\nSesion";
                lblCambioPassword.Text = "No recuerdo mi contraseña";
                lblTextoSinCuenta.Text = "¿No tienes una cuenta?";
                lblRegistrarse.Text = "Registrate";
                usuarioNoEncontrado = "Usuario no existente";
                contraseñaIncorrecta = "Contraseña incorrecta";
            }
            else
            {
                idioma = cbxIdioma.SelectedItem.ToString();
                lblTitulo.Text = "Login";
                lblCedula.Text = "Identity card";
                lblPassword.Text = "Password";               
                pbxIdioma.Image = fotoIngles;
                btnIniciarSesion.Text = "Login";
                lblCambioPassword.Text = "I don't remember my password";
                lblTextoSinCuenta.Text = "You don't have an account?";
                lblRegistrarse.Text = "Sign up";
                usuarioNoEncontrado = "Non-existent user";
                contraseñaIncorrecta = "Incorrect password";
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pbxIdioma_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            foreach(Usuario us in usuarios)
            {
                if (us.Ci.ToString() == txtCedula.Text)
                {
                    encontrado = us;
                }
                
            }

            if (encontrado != null)
            {
                if (encontrado.Password.ToString() == txtPassword.Text)
                {/*
                    try
                    {
                        register.Dispose();
                        registerDocente.Dispose();
                    }catch(System.NullReferenceException ex)
                    {

                    }
                    */
                    
                    if (encontrado.GetType().Name == "Docente")
                    {
                        txtCedula.Text = "";
                        txtPassword.Text = "";
                        principalChatDocente = new PrincipalChatDocente();
                        mensajesDocente = new MensajesDocente();
                        perfilDocente = new PerfilDocente();


                        principalChatDocente.Show();
                        this.Hide();

                        principalChatDocente.login = this;
                        principalChatDocente.mensajesDocente = mensajesDocente;
                        principalChatDocente.perfilDocente = perfilDocente;

                        mensajesDocente.login = this;
                        mensajesDocente.principalChatDocente = principalChatDocente;
                        mensajesDocente.perfilDocente = perfilDocente;

                        perfilDocente.login = this;
                        perfilDocente.principalChatDocente = principalChatDocente;
                        perfilDocente.mensajesDocente = mensajesDocente;
                        

                        
                    }
                    else if (encontrado.GetType().Name == "Alumno")
                    {
                        txtCedula.Text = "";
                        txtPassword.Text = "";
                        principalChatAlumno = new PrincipalChatAlumno();
                        mensajesAlumno = new MensajesAlumno();
                        perfilAlumno = new PerfilAlumno();


                        principalChatAlumno.Show();
                        this.Hide();

                        principalChatAlumno.login = this;
                        principalChatAlumno.mensajesAlumno = mensajesAlumno;
                        principalChatAlumno.perfilAlumno = perfilAlumno;

                        mensajesAlumno.login = this;
                        mensajesAlumno.principalChatAlumno = principalChatAlumno;
                        mensajesAlumno.perfilAlumno = perfilAlumno;

                        perfilAlumno.login = this;
                        perfilAlumno.principalChatAlumno = principalChatAlumno;
                        perfilAlumno.mensajesAlumno = mensajesAlumno;
                    }
                    else
                    {
                        MessageBox.Show("Desarrollo");
                    }
                }
                else
                {
                    MessageBox.Show(contraseñaIncorrecta);
                }
                
            }
            else
            {
                MessageBox.Show(usuarioNoEncontrado);
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            register = new Register();
            registerDocente = new RegisterDocente();
            registerAlumno = new RegisterAlumno();

            register.Show();
            this.Hide();

            register.login = this;
            register.registerDocente = registerDocente;
            register.registerAlumno = registerAlumno;

            registerDocente.login = this;
            registerDocente.register = register;
            registerAlumno.login = this;
            registerAlumno.register = register;
            




        }
    }
}

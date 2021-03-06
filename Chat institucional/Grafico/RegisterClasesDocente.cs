using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_institucional
{
    public partial class RegisterClasesDocente : Form
    {
        public Form login;
        public Form registerDocente;
        private int ychbx = 50, xchbx = 50, xlbl=50, ylbl=50;
        private int conteoClases=0;
        private Clase claseSeleccionada=null;
        private List<Clase> clases = new List<Clase>();
        private List<Asignatura> asigs = new List<Asignatura>();
        private List<Dicta> dictaAs = new List<Dicta>();
        private Docente docente = new Docente();
        public RegisterClasesDocente()
        {
            InitializeComponent();
            
            Text = "Register clase Docente";
            Icon = new Icon(Application.StartupPath + "logo imagen.ico");
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1280, 720);

            lblTitulo.Text = "Crea tu cuenta de docente";
            pbxVolver.Image = Image.FromFile("volver.png");
            pbxVolver.SizeMode = PictureBoxSizeMode.StretchImage;

            cbxAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrientacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxClases.DropDownStyle = ComboBoxStyle.DropDownList;
            panelAsignaturas.AutoScroll = true;
            panelAgregadas.AutoScroll = true;

            

            foreach (Orientacion ori in Login.orientaciones)
            {
                cbxOrientacion.Items.Add(ori.Nombre);
            }
        }

        public Docente Docente
        {
            set { docente = value; }
        }

        private void RegisterClasesDocente_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }


        private void CerrarForm(object sender, EventArgs e)
        {
            login.Dispose();
        }

        private void pbxVolver_Click(object sender, EventArgs e)
        {
            registerDocente.Show();
            this.Dispose();
        }

        private void cbxOrientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAsignaturas.Controls.Clear();
            ychbx = 50;
            xchbx = 50;
            cbxAnio.Items.Clear();
            cbxClases.Items.Clear();
            List<int> anios = new List<int>();

            foreach (Clase cla in Login.clases)
            {
                if (!anios.Contains(cla.Anio) && cla.Orientacion.Nombre == cbxOrientacion.SelectedItem.ToString())
                {
                    anios.Add(cla.Anio);
                }
            }
            anios.Sort();
            foreach (int anio in anios)
            {
                cbxAnio.Items.Add(anio);
            }
        }

        private void cbxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAsignaturas.Controls.Clear();
            ychbx = 50;
            xchbx = 50;
            cbxClases.Items.Clear();
            List<string> clase = new List<string>();
            foreach (Clase cla in Login.clases)
            {
                if (cla.Anio.ToString() == cbxAnio.SelectedItem.ToString() && cla.Orientacion.Nombre == cbxOrientacion.SelectedItem.ToString())
                {
                    clase.Add(cla.Nombre);
                }
            }
            clase.Sort();
            foreach (string cla in clase)
            {
                cbxClases.Items.Add(cla);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            docente.FotoDePerfil = Image.FromFile("Docente.png");
            foreach (Dicta dic in dictaAs)
            {
                dic.Docente = docente;
            }
            Login.dictan.AddRange(dictaAs);
            Login.usuarios.Add(docente);
            MessageBox.Show("Se ha creado el docente correctamente\nVolviendo al Login");
            login.Show();
            this.Dispose();
        }

        private void cbxClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAsignaturas.Controls.Clear();
            asigs.Clear();
            ychbx = 50;
            xchbx = 50;
            foreach (Clase cla in Login.clases)
            {
                if (cla.Orientacion.Nombre==cbxOrientacion.SelectedItem.ToString() && cla.Anio.ToString()==cbxAnio.SelectedItem.ToString() && cla.Nombre==cbxClases.SelectedItem.ToString())
                {
                    claseSeleccionada = cla;
                    
                    foreach(Contiene conti in Login.contienen)
                    {
                        if (conti.Orientacion.Nombre == claseSeleccionada.Orientacion.Nombre && conti.Asignatura.Anio==claseSeleccionada.Anio)
                        {
                            asigs.Add(conti.Asignatura);
                        }
                    }
                    
                    foreach (Asignatura asig in asigs)
                    {
                        CheckBox dina = new CheckBox();

                        dina.Height = 23;
                        dina.Width = 150;
                        dina.Location = new Point(xchbx, ychbx);
                        if (xchbx == 400)
                        {
                            xchbx = -125;
                            ychbx += 25;
                        }
                        xchbx += 175;
                        dina.Name = "chbx" + asig.Id;
                        dina.Text = asig.Nombre;

                        dina.CheckedChanged += new EventHandler(AsignaturaCambiada);
                        panelAsignaturas.Controls.Add(dina);
                    }
                }
            }

        }
        private void AsignaturaCambiada(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                foreach (Asignatura asig in asigs)
                {

                    if (((CheckBox)sender).Name == "chbx"+asig.Id)
                    {
                        Dicta dic = new Dicta();
                        dic.Asignatura = asig;
                        dic.Clase = claseSeleccionada;
                        dictaAs.Add(dic);
                    }
                            
                }
            }
            else
            {
                foreach (Asignatura asig in asigs)
                {
                    foreach (Dicta dic in dictaAs)
                    {
                        if (((CheckBox)sender).Name == "chbx" + asig.Id && dic.Clase==claseSeleccionada && dic.Asignatura==asig)
                        {
                            dictaAs.Remove(dic);
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            panelAgregadas.AutoScrollPosition =Point.Empty;
            panelAsignaturas.AutoScrollPosition = Point.Empty;
            if (!clases.Contains(claseSeleccionada))
            {
                
                Label dina = new Label();
                dina.Height = 46;
                dina.Width = 150;
                dina.Location = new Point(xlbl, ylbl);
                if (xlbl == 100)
                {
                    xlbl = -125;
                    ylbl += 25;
                }
                xlbl += 175;
                dina.Name = "lblClase" + conteoClases.ToString();
                conteoClases++;
                dina.Text = claseSeleccionada.Anio + "º" + claseSeleccionada.Nombre;
                foreach(Asignatura asig in asigs)
                {
                    foreach (Dicta dic in dictaAs)
                    {
                        if (dic.Asignatura==asig && dic.Clase==claseSeleccionada)
                        {
                            dina.Text += "\n" + asig.Nombre;
                            dina.Height += 23;
                        }
                    }
                    
                    
                }
                dina.Text += "\n" + claseSeleccionada.Orientacion.Nombre;/* + "\n(click para borrar)";
                dina.Click += new EventHandler(EliminarClase);*/
                panelAgregadas.Controls.Add(dina);
                panelAsignaturas.Controls.Clear();
                cbxOrientacion.SelectedItem = 0;
                cbxAnio.Items.Clear();
                cbxClases.Items.Clear();
                clases.Add(claseSeleccionada);
            }

        }
        /*private void EliminarClase(object sender, EventArgs e)
        {
            clases.Remove()
        }*/
    }
}

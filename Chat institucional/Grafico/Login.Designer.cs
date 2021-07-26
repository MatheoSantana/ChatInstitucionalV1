
namespace Chat_institucional
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxIdioma = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblCambioPassword = new System.Windows.Forms.Label();
            this.lblTextoSinCuenta = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Location = new System.Drawing.Point(1131, 12);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(121, 24);
            this.cbxIdioma.TabIndex = 0;
            this.cbxIdioma.SelectedIndexChanged += new System.EventHandler(this.cbxIdioma_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(450, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(382, 56);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inicio de sesion";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(450, 287);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(382, 23);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(450, 316);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(382, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(331, 290);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(113, 15);
            this.lblCedula.TabIndex = 4;
            this.lblCedula.Text = "Cedula de identidad";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(356, 316);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña";
            // 
            // pbxIdioma
            // 
            this.pbxIdioma.Location = new System.Drawing.Point(1077, 11);
            this.pbxIdioma.Name = "pbxIdioma";
            this.pbxIdioma.Size = new System.Drawing.Size(48, 27);
            this.pbxIdioma.TabIndex = 6;
            this.pbxIdioma.TabStop = false;
            this.pbxIdioma.Click += new System.EventHandler(this.pbxIdioma_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(692, 345);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(140, 70);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblCambioPassword
            // 
            this.lblCambioPassword.AutoSize = true;
            this.lblCambioPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblCambioPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblCambioPassword.Location = new System.Drawing.Point(450, 345);
            this.lblCambioPassword.Name = "lblCambioPassword";
            this.lblCambioPassword.Size = new System.Drawing.Size(151, 15);
            this.lblCambioPassword.TabIndex = 8;
            this.lblCambioPassword.Text = "No recuerdo mi contraseña";
            // 
            // lblTextoSinCuenta
            // 
            this.lblTextoSinCuenta.AutoSize = true;
            this.lblTextoSinCuenta.Location = new System.Drawing.Point(450, 373);
            this.lblTextoSinCuenta.Name = "lblTextoSinCuenta";
            this.lblTextoSinCuenta.Size = new System.Drawing.Size(129, 15);
            this.lblTextoSinCuenta.TabIndex = 9;
            this.lblTextoSinCuenta.Text = "¿No tienes una cuenta?";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Location = new System.Drawing.Point(450, 388);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(59, 15);
            this.lblRegistrarse.TabIndex = 10;
            this.lblRegistrarse.Text = "Registrate";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.lblTextoSinCuenta);
            this.Controls.Add(this.lblCambioPassword);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.pbxIdioma);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxIdioma);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbxIdioma;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblCambioPassword;
        private System.Windows.Forms.Label lblTextoSinCuenta;
        private System.Windows.Forms.Label lblRegistrarse;
    }
}


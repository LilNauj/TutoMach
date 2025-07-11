namespace TutoMatch
{
    partial class FrmFormulariodeUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenidosaGestiondeUsuarios = new Label();
            lblNombredeusuario = new Label();
            lblContraseña = new Label();
            label3 = new Label();
            txtNombredeusuario = new TextBox();
            txtContraseña = new TextBox();
            chkChequeo = new CheckBox();
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // lblBienvenidosaGestiondeUsuarios
            // 
            lblBienvenidosaGestiondeUsuarios.AutoSize = true;
            lblBienvenidosaGestiondeUsuarios.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidosaGestiondeUsuarios.Location = new Point(211, 37);
            lblBienvenidosaGestiondeUsuarios.Name = "lblBienvenidosaGestiondeUsuarios";
            lblBienvenidosaGestiondeUsuarios.Size = new Size(469, 28);
            lblBienvenidosaGestiondeUsuarios.TabIndex = 0;
            lblBienvenidosaGestiondeUsuarios.Text = "Bienvenidos a la Gestion de Perfil de Usuarios";
            // 
            // lblNombredeusuario
            // 
            lblNombredeusuario.AutoSize = true;
            lblNombredeusuario.Location = new Point(229, 93);
            lblNombredeusuario.Name = "lblNombredeusuario";
            lblNombredeusuario.Size = new Size(166, 25);
            lblNombredeusuario.TabIndex = 1;
            lblNombredeusuario.Text = "Nombre de usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(229, 147);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 296);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // txtNombredeusuario
            // 
            txtNombredeusuario.Location = new Point(401, 93);
            txtNombredeusuario.Name = "txtNombredeusuario";
            txtNombredeusuario.Size = new Size(138, 31);
            txtNombredeusuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(401, 147);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(138, 31);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // chkChequeo
            // 
            chkChequeo.AutoSize = true;
            chkChequeo.Location = new Point(545, 153);
            chkChequeo.Name = "chkChequeo";
            chkChequeo.Size = new Size(22, 21);
            chkChequeo.TabIndex = 6;
            chkChequeo.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(329, 202);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(119, 35);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(329, 263);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(119, 35);
            btnRegistrarse.TabIndex = 9;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // FrmFormulariodeUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 561);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSesion);
            Controls.Add(chkChequeo);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombredeusuario);
            Controls.Add(label3);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombredeusuario);
            Controls.Add(lblBienvenidosaGestiondeUsuarios);
            Name = "FrmFormulariodeUsuario";
            Text = "Formulario de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidosaGestiondeUsuarios;
        private Label lblNombredeusuario;
        private Label lblContraseña;
        private Label label3;
        private TextBox txtNombredeusuario;
        private TextBox txtContraseña;
        private CheckBox chkChequeo;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
    }
}
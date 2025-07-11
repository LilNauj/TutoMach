namespace TutoMatch
{
    partial class Form1
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
            btnProbarConexion = new Button();
            pictureBox1 = new PictureBox();
            lblNombredeUsuario = new Label();
            lblPasswordUsuario = new Label();
            lblRoldeUsuario = new Label();
            txtNombredeUsuario = new TextBox();
            txtPasswordUsuario = new TextBox();
            btnIniciarSesíon = new Button();
            cboRoldeUsuario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackgroundImage = Properties.Resources.descarga;
            btnProbarConexion.BackgroundImageLayout = ImageLayout.Stretch;
            btnProbarConexion.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbarConexion.Location = new Point(37, 443);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(160, 109);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar Conexion";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.taller1;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(37, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblNombredeUsuario
            // 
            lblNombredeUsuario.AutoSize = true;
            lblNombredeUsuario.Location = new Point(540, 136);
            lblNombredeUsuario.Name = "lblNombredeUsuario";
            lblNombredeUsuario.Size = new Size(168, 25);
            lblNombredeUsuario.TabIndex = 2;
            lblNombredeUsuario.Text = "Nombre de Usuario";
            // 
            // lblPasswordUsuario
            // 
            lblPasswordUsuario.AutoSize = true;
            lblPasswordUsuario.Location = new Point(540, 193);
            lblPasswordUsuario.Name = "lblPasswordUsuario";
            lblPasswordUsuario.Size = new Size(152, 25);
            lblPasswordUsuario.TabIndex = 3;
            lblPasswordUsuario.Text = "Password Usuario";
            // 
            // lblRoldeUsuario
            // 
            lblRoldeUsuario.AutoSize = true;
            lblRoldeUsuario.Location = new Point(540, 260);
            lblRoldeUsuario.Name = "lblRoldeUsuario";
            lblRoldeUsuario.Size = new Size(127, 25);
            lblRoldeUsuario.TabIndex = 4;
            lblRoldeUsuario.Text = "Rol de Usuario";
            // 
            // txtNombredeUsuario
            // 
            txtNombredeUsuario.Location = new Point(714, 136);
            txtNombredeUsuario.Name = "txtNombredeUsuario";
            txtNombredeUsuario.Size = new Size(150, 31);
            txtNombredeUsuario.TabIndex = 6;
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Location = new Point(714, 193);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.Size = new Size(150, 31);
            txtPasswordUsuario.TabIndex = 7;
            txtPasswordUsuario.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesíon
            // 
            btnIniciarSesíon.BackColor = SystemColors.GradientInactiveCaption;
            btnIniciarSesíon.BackgroundImage = Properties.Resources.pngtree_user_avatar_login_interface_abstract_blue_icon_png_image_3917504;
            btnIniciarSesíon.BackgroundImageLayout = ImageLayout.Stretch;
            btnIniciarSesíon.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesíon.ForeColor = SystemColors.ActiveCaptionText;
            btnIniciarSesíon.Location = new Point(329, 439);
            btnIniciarSesíon.Name = "btnIniciarSesíon";
            btnIniciarSesíon.Size = new Size(136, 113);
            btnIniciarSesíon.TabIndex = 9;
            btnIniciarSesíon.Text = "Iniciar Sesíon";
            btnIniciarSesíon.UseVisualStyleBackColor = true;
            btnIniciarSesíon.Click += btnIniciarSesíon_Click;
            // 
            // cboRoldeUsuario
            // 
            cboRoldeUsuario.FormattingEnabled = true;
            cboRoldeUsuario.Location = new Point(714, 252);
            cboRoldeUsuario.Name = "cboRoldeUsuario";
            cboRoldeUsuario.Size = new Size(150, 33);
            cboRoldeUsuario.TabIndex = 10;
            cboRoldeUsuario.SelectedIndexChanged += cboRoldeUsuario_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 795);
            Controls.Add(cboRoldeUsuario);
            Controls.Add(btnIniciarSesíon);
            Controls.Add(txtPasswordUsuario);
            Controls.Add(txtNombredeUsuario);
            Controls.Add(lblRoldeUsuario);
            Controls.Add(lblPasswordUsuario);
            Controls.Add(lblNombredeUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(btnProbarConexion);
            Name = "Form1";
            Text = "Formulario Inicio De Secion De Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProbarConexion;
        private PictureBox pictureBox1;
        private Label lblNombredeUsuario;
        private Label lblPasswordUsuario;
        private Label lblRoldeUsuario;
        private TextBox txtNombredeUsuario;
        private TextBox txtPasswordUsuario;
        private Button btnIniciarSesíon;
        private ComboBox cboRoldeUsuario;
    }
}

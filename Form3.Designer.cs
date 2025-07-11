namespace TutoMatch
{
    partial class frmfiltrartutores
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(364, 193);
            button1.Name = "button1";
            button1.Size = new Size(165, 34);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar Filtro";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 129);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 3;
            label2.Text = "Filtro a Docente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 31);
            textBox1.TabIndex = 5;
            textBox1.Text = "Juanito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(444, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 31);
            textBox2.TabIndex = 6;
            textBox2.Text = "Ingeniero, Magister";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._3750020;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 255);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmfiltrartutores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 376);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "frmfiltrartutores";
            Text = "Filtrar Tutores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}
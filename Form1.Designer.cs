namespace WinFormsTabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            Nombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 255, 192);
            panelprincipal.Controls.Add(Nombre);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(3, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(785, 426);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(378, 113);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(115, 167);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(138, 168);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(122, 113);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 23);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextChanged += textBox1_TextChanged;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(103, 71);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(133, 15);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "Cual tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Location = new Point(103, 30);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(110, 15);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de multiplicar";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.FromArgb(128, 255, 255);
            Nombre.Location = new Point(103, 216);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(181, 15);
            Nombre.TabIndex = 5;
            Nombre.Text = "Emmanuel De Jesus Lopez Garcia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private TextBox textBoxnum;
        private Button buttonver;
        private RichTextBox richTextBoxresultados;
        private Label Nombre;
    }
}

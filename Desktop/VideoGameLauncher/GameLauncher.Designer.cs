namespace VideoGameLauncher
{
    partial class GameLauncher
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonJugar = new System.Windows.Forms.Button();
            this.labelNumeroEstimulos = new System.Windows.Forms.Label();
            this.labelTamañoEstimulos = new System.Windows.Forms.Label();
            this.labelTamañoLetra = new System.Windows.Forms.Label();
            this.trackBarVelocidadRotación = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTamañoEstimulos = new System.Windows.Forms.TrackBar();
            this.trackBarTamañoLetra = new System.Windows.Forms.TrackBar();
            this.trackBarNumeroEstimulos = new System.Windows.Forms.TrackBar();
            this.textBoxNumEstimulos = new System.Windows.Forms.TextBox();
            this.textBoxTamEstimulos = new System.Windows.Forms.TextBox();
            this.textBoxTamLetra = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad = new System.Windows.Forms.TextBox();
            this.buttonColorFondo = new System.Windows.Forms.Button();
            this.colorDialogFondo = new System.Windows.Forms.ColorDialog();
            this.buttonColorPanel = new System.Windows.Forms.Button();
            this.colorDialogPanel = new System.Windows.Forms.ColorDialog();
            this.buttonColorEstimulo = new System.Windows.Forms.Button();
            this.colorDialogEstimulo = new System.Windows.Forms.ColorDialog();
            this.buttonColorLetra = new System.Windows.Forms.Button();
            this.colorDialogLetra = new System.Windows.Forms.ColorDialog();
            this.panelColorFondo = new System.Windows.Forms.Panel();
            this.panelColorPanel = new System.Windows.Forms.Panel();
            this.panelColorEstimulo = new System.Windows.Forms.Panel();
            this.panelColorLetra = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.radioButtonAvanzado = new System.Windows.Forms.RadioButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidadRotación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamañoEstimulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamañoLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumeroEstimulos)).BeginInit();
            this.SuspendLayout();
            // 
            // botonJugar
            // 
            this.botonJugar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.botonJugar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.botonJugar.Location = new System.Drawing.Point(584, 401);
            this.botonJugar.Margin = new System.Windows.Forms.Padding(4);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(143, 33);
            this.botonJugar.TabIndex = 0;
            this.botonJugar.Text = "Jugar";
            this.botonJugar.UseVisualStyleBackColor = false;
            this.botonJugar.Click += new System.EventHandler(this.botonJugar_Click_1);
            // 
            // labelNumeroEstimulos
            // 
            this.labelNumeroEstimulos.AutoSize = true;
            this.labelNumeroEstimulos.Location = new System.Drawing.Point(15, 55);
            this.labelNumeroEstimulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroEstimulos.Name = "labelNumeroEstimulos";
            this.labelNumeroEstimulos.Size = new System.Drawing.Size(121, 17);
            this.labelNumeroEstimulos.TabIndex = 1;
            this.labelNumeroEstimulos.Text = "Número estímulos";
            // 
            // labelTamañoEstimulos
            // 
            this.labelTamañoEstimulos.AutoSize = true;
            this.labelTamañoEstimulos.Location = new System.Drawing.Point(15, 118);
            this.labelTamañoEstimulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTamañoEstimulos.Name = "labelTamañoEstimulos";
            this.labelTamañoEstimulos.Size = new System.Drawing.Size(123, 17);
            this.labelTamañoEstimulos.TabIndex = 2;
            this.labelTamañoEstimulos.Text = "Tamaño estímulos";
            // 
            // labelTamañoLetra
            // 
            this.labelTamañoLetra.AutoSize = true;
            this.labelTamañoLetra.Location = new System.Drawing.Point(13, 181);
            this.labelTamañoLetra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTamañoLetra.Name = "labelTamañoLetra";
            this.labelTamañoLetra.Size = new System.Drawing.Size(93, 17);
            this.labelTamañoLetra.TabIndex = 6;
            this.labelTamañoLetra.Text = "TamañoLetra";
            // 
            // trackBarVelocidadRotación
            // 
            this.trackBarVelocidadRotación.AllowDrop = true;
            this.trackBarVelocidadRotación.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarVelocidadRotación.Location = new System.Drawing.Point(155, 244);
            this.trackBarVelocidadRotación.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarVelocidadRotación.Maximum = 50;
            this.trackBarVelocidadRotación.Minimum = 1;
            this.trackBarVelocidadRotación.Name = "trackBarVelocidadRotación";
            this.trackBarVelocidadRotación.Size = new System.Drawing.Size(525, 56);
            this.trackBarVelocidadRotación.TabIndex = 7;
            this.trackBarVelocidadRotación.Value = 1;
            this.trackBarVelocidadRotación.Scroll += new System.EventHandler(this.trackBarVelocidadRotación_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Velocidad rotación";
            // 
            // trackBarTamañoEstimulos
            // 
            this.trackBarTamañoEstimulos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarTamañoEstimulos.Location = new System.Drawing.Point(155, 118);
            this.trackBarTamañoEstimulos.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarTamañoEstimulos.Maximum = 100;
            this.trackBarTamañoEstimulos.Minimum = 1;
            this.trackBarTamañoEstimulos.Name = "trackBarTamañoEstimulos";
            this.trackBarTamañoEstimulos.Size = new System.Drawing.Size(525, 56);
            this.trackBarTamañoEstimulos.TabIndex = 9;
            this.trackBarTamañoEstimulos.Value = 1;
            this.trackBarTamañoEstimulos.Scroll += new System.EventHandler(this.trackBarTamañoEstimulos_Scroll_1);
            // 
            // trackBarTamañoLetra
            // 
            this.trackBarTamañoLetra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarTamañoLetra.Location = new System.Drawing.Point(155, 181);
            this.trackBarTamañoLetra.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarTamañoLetra.Minimum = 1;
            this.trackBarTamañoLetra.Name = "trackBarTamañoLetra";
            this.trackBarTamañoLetra.Size = new System.Drawing.Size(525, 56);
            this.trackBarTamañoLetra.TabIndex = 10;
            this.trackBarTamañoLetra.Value = 1;
            this.trackBarTamañoLetra.Scroll += new System.EventHandler(this.trackBarTamañoLetra_Scroll_1);
            // 
            // trackBarNumeroEstimulos
            // 
            this.trackBarNumeroEstimulos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarNumeroEstimulos.Location = new System.Drawing.Point(155, 55);
            this.trackBarNumeroEstimulos.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarNumeroEstimulos.Maximum = 20;
            this.trackBarNumeroEstimulos.Minimum = 1;
            this.trackBarNumeroEstimulos.Name = "trackBarNumeroEstimulos";
            this.trackBarNumeroEstimulos.Size = new System.Drawing.Size(525, 56);
            this.trackBarNumeroEstimulos.TabIndex = 11;
            this.trackBarNumeroEstimulos.Value = 1;
            this.trackBarNumeroEstimulos.Scroll += new System.EventHandler(this.trackBarNumeroEstimulos_Scroll_1);
            // 
            // textBoxNumEstimulos
            // 
            this.textBoxNumEstimulos.Enabled = false;
            this.textBoxNumEstimulos.Location = new System.Drawing.Point(689, 55);
            this.textBoxNumEstimulos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumEstimulos.Name = "textBoxNumEstimulos";
            this.textBoxNumEstimulos.Size = new System.Drawing.Size(36, 22);
            this.textBoxNumEstimulos.TabIndex = 12;
            this.textBoxNumEstimulos.Text = "1";
            // 
            // textBoxTamEstimulos
            // 
            this.textBoxTamEstimulos.Enabled = false;
            this.textBoxTamEstimulos.Location = new System.Drawing.Point(689, 119);
            this.textBoxTamEstimulos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTamEstimulos.Name = "textBoxTamEstimulos";
            this.textBoxTamEstimulos.Size = new System.Drawing.Size(36, 22);
            this.textBoxTamEstimulos.TabIndex = 13;
            this.textBoxTamEstimulos.Text = "1";
            // 
            // textBoxTamLetra
            // 
            this.textBoxTamLetra.Enabled = false;
            this.textBoxTamLetra.Location = new System.Drawing.Point(689, 181);
            this.textBoxTamLetra.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTamLetra.Name = "textBoxTamLetra";
            this.textBoxTamLetra.Size = new System.Drawing.Size(36, 22);
            this.textBoxTamLetra.TabIndex = 14;
            this.textBoxTamLetra.Text = "1";
            // 
            // textBoxVelocidad
            // 
            this.textBoxVelocidad.Enabled = false;
            this.textBoxVelocidad.Location = new System.Drawing.Point(689, 244);
            this.textBoxVelocidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVelocidad.Name = "textBoxVelocidad";
            this.textBoxVelocidad.Size = new System.Drawing.Size(36, 22);
            this.textBoxVelocidad.TabIndex = 15;
            this.textBoxVelocidad.Text = "1";
            // 
            // buttonColorFondo
            // 
            this.buttonColorFondo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonColorFondo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonColorFondo.Location = new System.Drawing.Point(155, 306);
            this.buttonColorFondo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorFondo.Name = "buttonColorFondo";
            this.buttonColorFondo.Size = new System.Drawing.Size(187, 28);
            this.buttonColorFondo.TabIndex = 16;
            this.buttonColorFondo.Text = "Color Fondo";
            this.buttonColorFondo.UseVisualStyleBackColor = false;
            this.buttonColorFondo.Click += new System.EventHandler(this.buttonColorFondo_Click);
            // 
            // buttonColorPanel
            // 
            this.buttonColorPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonColorPanel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonColorPanel.Location = new System.Drawing.Point(155, 343);
            this.buttonColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorPanel.Name = "buttonColorPanel";
            this.buttonColorPanel.Size = new System.Drawing.Size(187, 28);
            this.buttonColorPanel.TabIndex = 17;
            this.buttonColorPanel.Text = "Color Panel";
            this.buttonColorPanel.UseVisualStyleBackColor = false;
            this.buttonColorPanel.Click += new System.EventHandler(this.buttonColorPanel_Click_1);
            // 
            // buttonColorEstimulo
            // 
            this.buttonColorEstimulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonColorEstimulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonColorEstimulo.Location = new System.Drawing.Point(540, 306);
            this.buttonColorEstimulo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorEstimulo.Name = "buttonColorEstimulo";
            this.buttonColorEstimulo.Size = new System.Drawing.Size(187, 28);
            this.buttonColorEstimulo.TabIndex = 18;
            this.buttonColorEstimulo.Text = "Color Estimulo";
            this.buttonColorEstimulo.UseVisualStyleBackColor = false;
            this.buttonColorEstimulo.Click += new System.EventHandler(this.buttonColorEstimulo_Click_1);
            // 
            // buttonColorLetra
            // 
            this.buttonColorLetra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonColorLetra.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonColorLetra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonColorLetra.Location = new System.Drawing.Point(540, 343);
            this.buttonColorLetra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorLetra.Name = "buttonColorLetra";
            this.buttonColorLetra.Size = new System.Drawing.Size(187, 28);
            this.buttonColorLetra.TabIndex = 19;
            this.buttonColorLetra.Text = "Color Letra";
            this.buttonColorLetra.UseVisualStyleBackColor = false;
            this.buttonColorLetra.Click += new System.EventHandler(this.buttonColorLetra_Click_1);
            // 
            // panelColorFondo
            // 
            this.panelColorFondo.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorFondo.Location = new System.Drawing.Point(23, 306);
            this.panelColorFondo.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorFondo.Name = "panelColorFondo";
            this.panelColorFondo.Size = new System.Drawing.Size(123, 28);
            this.panelColorFondo.TabIndex = 20;
            // 
            // panelColorPanel
            // 
            this.panelColorPanel.BackColor = System.Drawing.Color.Lime;
            this.panelColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorPanel.Location = new System.Drawing.Point(23, 343);
            this.panelColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorPanel.Name = "panelColorPanel";
            this.panelColorPanel.Size = new System.Drawing.Size(123, 28);
            this.panelColorPanel.TabIndex = 21;
            // 
            // panelColorEstimulo
            // 
            this.panelColorEstimulo.BackColor = System.Drawing.Color.Red;
            this.panelColorEstimulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorEstimulo.Location = new System.Drawing.Point(408, 306);
            this.panelColorEstimulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorEstimulo.Name = "panelColorEstimulo";
            this.panelColorEstimulo.Size = new System.Drawing.Size(123, 28);
            this.panelColorEstimulo.TabIndex = 22;
            // 
            // panelColorLetra
            // 
            this.panelColorLetra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelColorLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorLetra.Location = new System.Drawing.Point(408, 343);
            this.panelColorLetra.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorLetra.Name = "panelColorLetra";
            this.panelColorLetra.Size = new System.Drawing.Size(123, 28);
            this.panelColorLetra.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Modo Juego";
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(155, 401);
            this.radioButtonSimple.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(71, 21);
            this.radioButtonSimple.TabIndex = 25;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            this.radioButtonSimple.CheckedChanged += new System.EventHandler(this.radioButtonSimple_CheckedChanged);
            // 
            // radioButtonAvanzado
            // 
            this.radioButtonAvanzado.AutoSize = true;
            this.radioButtonAvanzado.Checked = true;
            this.radioButtonAvanzado.Location = new System.Drawing.Point(244, 401);
            this.radioButtonAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAvanzado.Name = "radioButtonAvanzado";
            this.radioButtonAvanzado.Size = new System.Drawing.Size(92, 21);
            this.radioButtonAvanzado.TabIndex = 26;
            this.radioButtonAvanzado.TabStop = true;
            this.radioButtonAvanzado.Text = "Avanzado";
            this.radioButtonAvanzado.UseVisualStyleBackColor = true;
            this.radioButtonAvanzado.CheckedChanged += new System.EventHandler(this.radioButtonAvanzado_CheckedChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(285, 11);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(179, 24);
            this.labelTitulo.TabIndex = 27;
            this.labelTitulo.Text = "Selección de Juego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 448);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.radioButtonAvanzado);
            this.Controls.Add(this.radioButtonSimple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelColorLetra);
            this.Controls.Add(this.panelColorEstimulo);
            this.Controls.Add(this.panelColorPanel);
            this.Controls.Add(this.panelColorFondo);
            this.Controls.Add(this.buttonColorLetra);
            this.Controls.Add(this.buttonColorEstimulo);
            this.Controls.Add(this.buttonColorPanel);
            this.Controls.Add(this.buttonColorFondo);
            this.Controls.Add(this.textBoxVelocidad);
            this.Controls.Add(this.textBoxTamLetra);
            this.Controls.Add(this.textBoxTamEstimulos);
            this.Controls.Add(this.textBoxNumEstimulos);
            this.Controls.Add(this.trackBarNumeroEstimulos);
            this.Controls.Add(this.trackBarTamañoLetra);
            this.Controls.Add(this.trackBarTamañoEstimulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarVelocidadRotación);
            this.Controls.Add(this.labelTamañoLetra);
            this.Controls.Add(this.labelTamañoEstimulos);
            this.Controls.Add(this.labelNumeroEstimulos);
            this.Controls.Add(this.botonJugar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "VideoGame";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidadRotación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamañoEstimulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamañoLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumeroEstimulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.Label labelNumeroEstimulos;
        private System.Windows.Forms.Label labelTamañoEstimulos;
        private System.Windows.Forms.Label labelTamañoLetra;
        private System.Windows.Forms.TrackBar trackBarVelocidadRotación;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTamañoEstimulos;
        private System.Windows.Forms.TrackBar trackBarTamañoLetra;
        private System.Windows.Forms.TrackBar trackBarNumeroEstimulos;
        private System.Windows.Forms.TextBox textBoxNumEstimulos;
        private System.Windows.Forms.TextBox textBoxTamEstimulos;
        private System.Windows.Forms.TextBox textBoxTamLetra;
        private System.Windows.Forms.TextBox textBoxVelocidad;
        private System.Windows.Forms.Button buttonColorFondo;
        private System.Windows.Forms.ColorDialog colorDialogFondo;
        private System.Windows.Forms.Button buttonColorPanel;
        private System.Windows.Forms.ColorDialog colorDialogPanel;
        private System.Windows.Forms.Button buttonColorEstimulo;
        private System.Windows.Forms.ColorDialog colorDialogEstimulo;
        private System.Windows.Forms.Button buttonColorLetra;
        private System.Windows.Forms.ColorDialog colorDialogLetra;
        private System.Windows.Forms.Panel panelColorFondo;
        private System.Windows.Forms.Panel panelColorPanel;
        private System.Windows.Forms.Panel panelColorEstimulo;
        private System.Windows.Forms.Panel panelColorLetra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.RadioButton radioButtonAvanzado;
        private System.Windows.Forms.Label labelTitulo;
    }
}
namespace WinFormsApp1
{
    partial class FmrLLamador
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
            txtNroDestino = new TextBox();
            gpbPanel = new GroupBox();
            btnNumeral = new Button();
            btnCero = new Button();
            btnAsterisco = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnLlamar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtNroOrigen = new TextBox();
            cmbFranja = new ComboBox();
            gpbPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNroDestino
            // 
            txtNroDestino.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroDestino.Location = new Point(12, 34);
            txtNroDestino.Multiline = true;
            txtNroDestino.Name = "txtNroDestino";
            txtNroDestino.Size = new Size(328, 35);
            txtNroDestino.TabIndex = 0;
            txtNroDestino.Text = "Nro Destino";
            txtNroDestino.TextChanged += txtNroDestino_TextChanged;
            // 
            // gpbPanel
            // 
            gpbPanel.Controls.Add(btnNumeral);
            gpbPanel.Controls.Add(btnCero);
            gpbPanel.Controls.Add(btnAsterisco);
            gpbPanel.Controls.Add(btnNueve);
            gpbPanel.Controls.Add(btnOcho);
            gpbPanel.Controls.Add(btnSiete);
            gpbPanel.Controls.Add(btnSeis);
            gpbPanel.Controls.Add(btnCinco);
            gpbPanel.Controls.Add(btnCuatro);
            gpbPanel.Controls.Add(btnTres);
            gpbPanel.Controls.Add(btnDos);
            gpbPanel.Controls.Add(btnUno);
            gpbPanel.Location = new Point(12, 95);
            gpbPanel.Name = "gpbPanel";
            gpbPanel.Size = new Size(148, 206);
            gpbPanel.TabIndex = 1;
            gpbPanel.TabStop = false;
            gpbPanel.Text = "Panel";
            // 
            // btnNumeral
            // 
            btnNumeral.FlatStyle = FlatStyle.Popup;
            btnNumeral.Location = new Point(92, 153);
            btnNumeral.Name = "btnNumeral";
            btnNumeral.Size = new Size(37, 39);
            btnNumeral.TabIndex = 11;
            btnNumeral.Text = "#";
            btnNumeral.UseVisualStyleBackColor = true;
            btnNumeral.Click += btnNumeral_Click;
            // 
            // btnCero
            // 
            btnCero.FlatStyle = FlatStyle.Popup;
            btnCero.Location = new Point(49, 153);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(37, 39);
            btnCero.TabIndex = 10;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += btnCero_Click;
            // 
            // btnAsterisco
            // 
            btnAsterisco.FlatStyle = FlatStyle.Popup;
            btnAsterisco.Location = new Point(6, 153);
            btnAsterisco.Name = "btnAsterisco";
            btnAsterisco.Size = new Size(37, 39);
            btnAsterisco.TabIndex = 9;
            btnAsterisco.Text = "*";
            btnAsterisco.UseVisualStyleBackColor = true;
            btnAsterisco.Click += btnAsterisco_Click;
            // 
            // btnNueve
            // 
            btnNueve.FlatStyle = FlatStyle.Popup;
            btnNueve.Location = new Point(92, 112);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(37, 39);
            btnNueve.TabIndex = 8;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += btnNueve_Click;
            // 
            // btnOcho
            // 
            btnOcho.FlatStyle = FlatStyle.Popup;
            btnOcho.Location = new Point(49, 112);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(37, 39);
            btnOcho.TabIndex = 7;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += btnOcho_Click;
            // 
            // btnSiete
            // 
            btnSiete.FlatStyle = FlatStyle.Popup;
            btnSiete.Location = new Point(6, 112);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(37, 39);
            btnSiete.TabIndex = 6;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += btnSiete_Click;
            // 
            // btnSeis
            // 
            btnSeis.FlatStyle = FlatStyle.Popup;
            btnSeis.Location = new Point(92, 67);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(37, 39);
            btnSeis.TabIndex = 5;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Location = new Point(49, 67);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(37, 39);
            btnCinco.TabIndex = 4;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.FlatStyle = FlatStyle.Popup;
            btnCuatro.Location = new Point(6, 67);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(37, 39);
            btnCuatro.TabIndex = 3;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += btnCuatro_Click;
            // 
            // btnTres
            // 
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Location = new Point(92, 22);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(37, 39);
            btnTres.TabIndex = 2;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnDos
            // 
            btnDos.BackColor = SystemColors.ScrollBar;
            btnDos.FlatStyle = FlatStyle.Popup;
            btnDos.Location = new Point(49, 22);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(37, 39);
            btnDos.TabIndex = 1;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // btnUno
            // 
            btnUno.BackColor = SystemColors.ScrollBar;
            btnUno.BackgroundImageLayout = ImageLayout.None;
            btnUno.FlatStyle = FlatStyle.Popup;
            btnUno.ForeColor = SystemColors.ControlText;
            btnUno.Location = new Point(6, 22);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(37, 39);
            btnUno.TabIndex = 0;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += btnUno_Click;
            // 
            // btnLlamar
            // 
            btnLlamar.BackColor = SystemColors.ButtonFace;
            btnLlamar.FlatStyle = FlatStyle.Popup;
            btnLlamar.ForeColor = SystemColors.ControlText;
            btnLlamar.Location = new Point(173, 117);
            btnLlamar.Name = "btnLlamar";
            btnLlamar.Size = new Size(167, 39);
            btnLlamar.TabIndex = 2;
            btnLlamar.Text = "Llamar";
            btnLlamar.UseVisualStyleBackColor = false;
            btnLlamar.Click += btnLlamar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Location = new Point(173, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 39);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(173, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(167, 39);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNroOrigen
            // 
            txtNroOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroOrigen.Location = new Point(173, 214);
            txtNroOrigen.Name = "txtNroOrigen";
            txtNroOrigen.Size = new Size(167, 23);
            txtNroOrigen.TabIndex = 5;
            txtNroOrigen.Text = "NroOrigen";
            // 
            // cmbFranja
            // 
            cmbFranja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFranja.FormattingEnabled = true;
            cmbFranja.Location = new Point(12, 322);
            cmbFranja.Name = "cmbFranja";
            cmbFranja.Size = new Size(328, 29);
            cmbFranja.TabIndex = 6;
            cmbFranja.Text = "Franja";
            // 
            // FmrLLamador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(352, 382);
            Controls.Add(cmbFranja);
            Controls.Add(txtNroOrigen);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLlamar);
            Controls.Add(gpbPanel);
            Controls.Add(txtNroDestino);
            Name = "FmrLLamador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Llamador";
            TransparencyKey = SystemColors.ActiveCaption;
            Load += FmrLLamador_Load;
            gpbPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNroDestino;
        private GroupBox gpbPanel;
        private Button btnNumeral;
        private Button btnCero;
        private Button btnAsterisco;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnLlamar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtNroOrigen;
        private ComboBox cmbFranja;
    }
}
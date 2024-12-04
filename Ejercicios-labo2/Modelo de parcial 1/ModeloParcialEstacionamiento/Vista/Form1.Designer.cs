namespace Vista
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
            btnAgregar = new Button();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            txtNombreEstacionamiento = new TextBox();
            lstVehiculos = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(82, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(179, 81);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(127, 46);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(111, 23);
            cmbTipoVehiculo.TabIndex = 1;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(127, 138);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(111, 23);
            cmbTipoMoto.TabIndex = 2;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(127, 93);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(111, 23);
            txtPatente.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(244, 138);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(111, 23);
            txtMarca.TabIndex = 4;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(21, 49);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(100, 15);
            lblTipoVehiculo.TabIndex = 5;
            lblTipoVehiculo.Text = "Tipo de Vehiculo: ";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(21, 93);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 6;
            lblPatente.Text = "Patente:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(21, 141);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "asdsad";
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.BackColor = Color.FromArgb(192, 255, 192);
            txtNombreEstacionamiento.Location = new Point(377, 10);
            txtNombreEstacionamiento.Multiline = true;
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(360, 54);
            txtNombreEstacionamiento.TabIndex = 8;
            // 
            // lstVehiculos
            // 
            lstVehiculos.BackColor = Color.FromArgb(192, 255, 192);
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(377, 93);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(360, 379);
            lstVehiculos.TabIndex = 9;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(749, 498);
            Controls.Add(lstVehiculos);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento: Morquio Tres Atados";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private TextBox txtNombreEstacionamiento;
        private ListBox lstVehiculos;
    }
}

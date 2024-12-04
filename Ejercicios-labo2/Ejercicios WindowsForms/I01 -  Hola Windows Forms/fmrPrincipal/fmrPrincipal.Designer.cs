namespace fmrPrincipal
{
    partial class fmrPrincipal
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
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnSaludo = new Button();
            lblMateriaFavorita = new Label();
            cmbMaterias = new ComboBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(35, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(202, 44);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(202, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(227, 188);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(75, 23);
            btnSaludo.TabIndex = 6;
            btnSaludo.Text = "Saludar";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // lblMateriaFavorita
            // 
            lblMateriaFavorita.AutoSize = true;
            lblMateriaFavorita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateriaFavorita.Location = new Point(35, 110);
            lblMateriaFavorita.Name = "lblMateriaFavorita";
            lblMateriaFavorita.Size = new Size(97, 15);
            lblMateriaFavorita.TabIndex = 4;
            lblMateriaFavorita.Text = "Materia favorita";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(35, 138);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(267, 23);
            cmbMaterias.TabIndex = 5;
            // 
            // fmrPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 253);
            Controls.Add(cmbMaterias);
            Controls.Add(lblMateriaFavorita);
            Controls.Add(btnSaludo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmrPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hola windows forms";
            Load += fmrPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnSaludo;
        private Label lblMateriaFavorita;
        private ComboBox cmbMaterias;
    }
}

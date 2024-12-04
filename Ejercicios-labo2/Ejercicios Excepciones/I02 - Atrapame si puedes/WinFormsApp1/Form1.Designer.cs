namespace WinFormsApp1
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
            lblKilometros = new Label();
            lblLitros = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            rtbVista = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(21, 29);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Location = new Point(21, 84);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(36, 15);
            lblLitros.TabIndex = 1;
            lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(21, 47);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(117, 23);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(21, 102);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(117, 23);
            txtLitros.TabIndex = 3;
            // 
            // rtbVista
            // 
            rtbVista.Location = new Point(158, 29);
            rtbVista.Name = "rtbVista";
            rtbVista.Size = new Size(198, 156);
            rtbVista.TabIndex = 4;
            rtbVista.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(21, 162);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 227);
            Controls.Add(btnCalcular);
            Controls.Add(rtbVista);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private RichTextBox rtbVista;
        private Button btnCalcular;
    }
}

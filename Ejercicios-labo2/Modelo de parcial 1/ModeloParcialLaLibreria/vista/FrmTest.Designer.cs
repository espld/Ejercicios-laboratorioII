namespace vista
{
    partial class FrmTest
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
            lstStock = new ListBox();
            rtbInforme = new RichTextBox();
            btnVender = new Button();
            btnVerInforme = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 15;
            lstStock.Location = new Point(12, 23);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(294, 289);
            lstStock.TabIndex = 0;
            // 
            // rtbInforme
            // 
            rtbInforme.Location = new Point(323, 23);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(338, 476);
            rtbInforme.TabIndex = 1;
            rtbInforme.Text = "";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(12, 331);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(294, 52);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Location = new Point(12, 389);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(294, 52);
            btnVerInforme.TabIndex = 3;
            btnVerInforme.Text = "Ver Informe";
            btnVerInforme.UseVisualStyleBackColor = true;
            btnVerInforme.Click += btnVerInforme_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 447);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(294, 52);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 522);
            Controls.Add(btnSalir);
            Controls.Add(btnVerInforme);
            Controls.Add(btnVender);
            Controls.Add(rtbInforme);
            Controls.Add(lstStock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tester App";
            Load += FrmTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstStock;
        private RichTextBox rtbInforme;
        private Button btnVender;
        private Button btnVerInforme;
        private Button btnSalir;
    }
}

namespace Vista
{
    partial class FormPrincipal
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
            rtbAppInstaladas = new RichTextBox();
            rtbAppNoInstaladas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            rtbAppInstaladas.BackColor = SystemColors.InfoText;
            rtbAppInstaladas.ForeColor = Color.White;
            rtbAppInstaladas.Location = new Point(12, 27);
            rtbAppInstaladas.Name = "rtbAppInstaladas";
            rtbAppInstaladas.Size = new Size(309, 644);
            rtbAppInstaladas.TabIndex = 0;
            rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = SystemColors.MenuText;
            rtbAppNoInstaladas.ForeColor = Color.White;
            rtbAppNoInstaladas.Location = new Point(479, 27);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(309, 644);
            rtbAppNoInstaladas.TabIndex = 1;
            rtbAppNoInstaladas.Text = "";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 683);
            Controls.Add(rtbAppNoInstaladas);
            Controls.Add(rtbAppInstaladas);
            Name = "FormPrincipal";
            Text = "El dispositivo";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbAppInstaladas;
        private RichTextBox rtbAppNoInstaladas;
    }
}

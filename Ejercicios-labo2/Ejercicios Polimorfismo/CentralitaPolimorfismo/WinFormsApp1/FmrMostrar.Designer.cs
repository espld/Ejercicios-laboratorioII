﻿namespace WinFormsApp1
{
    partial class FmrMostrar
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
            rtbMostrar = new RichTextBox();
            SuspendLayout();
            // 
            // rtbMostrar
            // 
            rtbMostrar.Location = new Point(12, 12);
            rtbMostrar.Name = "rtbMostrar";
            rtbMostrar.Size = new Size(751, 426);
            rtbMostrar.TabIndex = 0;
            rtbMostrar.Text = "";
            // 
            // FmrMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbMostrar);
            Name = "FmrMostrar";
            Text = "FmrMostrar";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbMostrar;
    }
}
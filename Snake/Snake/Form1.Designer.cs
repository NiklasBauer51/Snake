﻿namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameOverlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.AutoSize = true;
            this.GameOverlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlabel.Location = new System.Drawing.Point(161, 24);
            this.GameOverlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(297, 46);
            this.GameOverlabel.TabIndex = 4;
            this.GameOverlabel.Text = "GameOverlabel";
            this.GameOverlabel.Visible = false;
            this.GameOverlabel.Click += new System.EventHandler(this.GameOverlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(609, 702);
            this.Controls.Add(this.GameOverlabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameOverlabel;
    }
}


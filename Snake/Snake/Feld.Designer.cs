namespace Snake
{
    partial class Feld
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
            this.components = new System.ComponentModel.Container();
            this.GameOverlabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelAbgrenzung = new System.Windows.Forms.Label();
            this.ScoreLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.AutoSize = true;
            this.GameOverlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlabel.Location = new System.Drawing.Point(12, 9);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(239, 37);
            this.GameOverlabel.TabIndex = 4;
            this.GameOverlabel.Text = "GameOverlabel";
            this.GameOverlabel.Visible = false;
            this.GameOverlabel.Click += new System.EventHandler(this.GameOverlabel_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(528, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(80, 37);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Zahl";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // LabelAbgrenzung
            // 
            this.LabelAbgrenzung.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelAbgrenzung.Location = new System.Drawing.Point(410, 0);
            this.LabelAbgrenzung.Name = "LabelAbgrenzung";
            this.LabelAbgrenzung.Size = new System.Drawing.Size(10, 465);
            this.LabelAbgrenzung.TabIndex = 6;
            // 
            // ScoreLabelText
            // 
            this.ScoreLabelText.AutoSize = true;
            this.ScoreLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabelText.Location = new System.Drawing.Point(426, 9);
            this.ScoreLabelText.Name = "ScoreLabelText";
            this.ScoreLabelText.Size = new System.Drawing.Size(109, 37);
            this.ScoreLabelText.TabIndex = 7;
            this.ScoreLabelText.Text = "Score:";
            // 
            // Feld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ScoreLabelText);
            this.Controls.Add(this.LabelAbgrenzung);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverlabel);
            this.Name = "Feld";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameOverlabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label LabelAbgrenzung;
        private System.Windows.Forms.Label ScoreLabelText;
    }
}


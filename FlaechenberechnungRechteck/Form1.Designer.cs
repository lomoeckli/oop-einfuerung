namespace FlaechenberechnungRechteck
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
            this.Berechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHoehe = new System.Windows.Forms.TextBox();
            this.textBoxBreite = new System.Windows.Forms.TextBox();
            this.textBoxResulltat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Berechnen
            // 
            this.Berechnen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Berechnen.Location = new System.Drawing.Point(644, 70);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(188, 43);
            this.Berechnen.TabIndex = 0;
            this.Berechnen.Text = "Fläche berechnen";
            this.Berechnen.UseVisualStyleBackColor = false;
            this.Berechnen.Click += new System.EventHandler(this.Berechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ausgabe (Fläche)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(644, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Beenden";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxHoehe
            // 
            this.textBoxHoehe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoehe.Location = new System.Drawing.Point(325, 117);
            this.textBoxHoehe.Name = "textBoxHoehe";
            this.textBoxHoehe.Size = new System.Drawing.Size(205, 22);
            this.textBoxHoehe.TabIndex = 6;
            // 
            // textBoxBreite
            // 
            this.textBoxBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBreite.Location = new System.Drawing.Point(325, 70);
            this.textBoxBreite.Name = "textBoxBreite";
            this.textBoxBreite.Size = new System.Drawing.Size(205, 22);
            this.textBoxBreite.TabIndex = 7;
            // 
            // textBoxResulltat
            // 
            this.textBoxResulltat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxResulltat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResulltat.Location = new System.Drawing.Point(325, 214);
            this.textBoxResulltat.Name = "textBoxResulltat";
            this.textBoxResulltat.Size = new System.Drawing.Size(205, 22);
            this.textBoxResulltat.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(906, 295);
            this.Controls.Add(this.textBoxResulltat);
            this.Controls.Add(this.textBoxBreite);
            this.Controls.Add(this.textBoxHoehe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Berechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxHoehe;
        private System.Windows.Forms.TextBox textBoxBreite;
        private System.Windows.Forms.TextBox textBoxResulltat;
    }
}


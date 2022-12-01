namespace Tannenbaum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrownHeight = new System.Windows.Forms.TextBox();
            this.TrunkHeight = new System.Windows.Forms.TextBox();
            this.Trunkwidth = new System.Windows.Forms.TextBox();
            this.TreeDrawing = new System.Windows.Forms.TextBox();
            this.DrawTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trunk width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trunk height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crown height";
            // 
            // CrownHeight
            // 
            this.CrownHeight.Location = new System.Drawing.Point(135, 109);
            this.CrownHeight.Name = "CrownHeight";
            this.CrownHeight.Size = new System.Drawing.Size(100, 22);
            this.CrownHeight.TabIndex = 3;
            // 
            // TrunkHeight
            // 
            this.TrunkHeight.Location = new System.Drawing.Point(135, 65);
            this.TrunkHeight.Name = "TrunkHeight";
            this.TrunkHeight.Size = new System.Drawing.Size(100, 22);
            this.TrunkHeight.TabIndex = 5;
            // 
            // Trunkwidth
            // 
            this.Trunkwidth.Location = new System.Drawing.Point(135, 27);
            this.Trunkwidth.Name = "Trunkwidth";
            this.Trunkwidth.Size = new System.Drawing.Size(100, 22);
            this.Trunkwidth.TabIndex = 6;
            // 
            // TreeDrawing
            // 
            this.TreeDrawing.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeDrawing.Location = new System.Drawing.Point(12, 153);
            this.TreeDrawing.Multiline = true;
            this.TreeDrawing.Name = "TreeDrawing";
            this.TreeDrawing.Size = new System.Drawing.Size(507, 538);
            this.TreeDrawing.TabIndex = 7;
            // 
            // DrawTree
            // 
            this.DrawTree.Location = new System.Drawing.Point(314, 108);
            this.DrawTree.Name = "DrawTree";
            this.DrawTree.Size = new System.Drawing.Size(130, 27);
            this.DrawTree.TabIndex = 8;
            this.DrawTree.Text = "Draw tree";
            this.DrawTree.UseVisualStyleBackColor = true;
            this.DrawTree.Click += new System.EventHandler(this.DrawTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(531, 703);
            this.Controls.Add(this.DrawTree);
            this.Controls.Add(this.TreeDrawing);
            this.Controls.Add(this.Trunkwidth);
            this.Controls.Add(this.TrunkHeight);
            this.Controls.Add(this.CrownHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CrownHeight;
        private System.Windows.Forms.TextBox TrunkHeight;
        private System.Windows.Forms.TextBox Trunkwidth;
        private System.Windows.Forms.TextBox TreeDrawing;
        private System.Windows.Forms.Button DrawTree;
    }
}


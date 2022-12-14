namespace AutoSimulator
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
            this.PS = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelOnOff = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kmh = new System.Windows.Forms.TextBox();
            this.gear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto wählen:";
            // 
            // PS
            // 
            this.PS.AutoSize = true;
            this.PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS.ForeColor = System.Drawing.Color.Maroon;
            this.PS.Location = new System.Drawing.Point(482, 33);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(64, 29);
            this.PS.TabIndex = 1;
            this.PS.Text = "0 PS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.PanelOnOff);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 473);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSimulator.Properties.Resources.Carkey1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoSimulator.Properties.Resources.horn;
            this.pictureBox2.Location = new System.Drawing.Point(22, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PanelOnOff
            // 
            this.PanelOnOff.BackColor = System.Drawing.Color.Red;
            this.PanelOnOff.Location = new System.Drawing.Point(107, 21);
            this.PanelOnOff.Name = "PanelOnOff";
            this.PanelOnOff.Size = new System.Drawing.Size(23, 19);
            this.PanelOnOff.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gear);
            this.panel1.Controls.Add(this.kmh);
            this.panel1.Location = new System.Drawing.Point(147, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 149);
            this.panel1.TabIndex = 4;
            // 
            // kmh
            // 
            this.kmh.BackColor = System.Drawing.Color.Black;
            this.kmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kmh.Location = new System.Drawing.Point(34, 35);
            this.kmh.Multiline = true;
            this.kmh.Name = "kmh";
            this.kmh.Size = new System.Drawing.Size(251, 73);
            this.kmh.TabIndex = 0;
            this.kmh.Text = "0";
            this.kmh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gear
            // 
            this.gear.BackColor = System.Drawing.Color.Black;
            this.gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gear.Location = new System.Drawing.Point(330, 35);
            this.gear.Multiline = true;
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(91, 73);
            this.gear.TabIndex = 1;
            this.gear.Text = "1";
            this.gear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gear";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 225);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bremse";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(502, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 225);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(751, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gear;
        private System.Windows.Forms.TextBox kmh;
        private System.Windows.Forms.Panel PanelOnOff;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


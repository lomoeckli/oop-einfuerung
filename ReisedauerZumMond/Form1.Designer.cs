namespace ReisedauerZumMond
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
            this.SelectDays = new System.Windows.Forms.RadioButton();
            this.SelectHours = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.CalculateTravelDuration = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTravelTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectDays
            // 
            this.SelectDays.AutoSize = true;
            this.SelectDays.Location = new System.Drawing.Point(50, 52);
            this.SelectDays.Name = "SelectDays";
            this.SelectDays.Size = new System.Drawing.Size(75, 22);
            this.SelectDays.TabIndex = 1;
            this.SelectDays.TabStop = true;
            this.SelectDays.Text = "in days";
            this.SelectDays.UseVisualStyleBackColor = true;
            // 
            // SelectHours
            // 
            this.SelectHours.AutoSize = true;
            this.SelectHours.Location = new System.Drawing.Point(149, 52);
            this.SelectHours.Name = "SelectHours";
            this.SelectHours.Size = new System.Drawing.Size(82, 22);
            this.SelectHours.TabIndex = 2;
            this.SelectHours.TabStop = true;
            this.SelectHours.Text = "in hours";
            this.SelectHours.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed km/h";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(149, 112);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(137, 24);
            this.Speed.TabIndex = 4;
            // 
            // CalculateTravelDuration
            // 
            this.CalculateTravelDuration.BackColor = System.Drawing.SystemColors.Window;
            this.CalculateTravelDuration.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.CalculateTravelDuration.Location = new System.Drawing.Point(50, 158);
            this.CalculateTravelDuration.Name = "CalculateTravelDuration";
            this.CalculateTravelDuration.Size = new System.Drawing.Size(293, 31);
            this.CalculateTravelDuration.TabIndex = 5;
            this.CalculateTravelDuration.Text = "Calculate travel duration";
            this.CalculateTravelDuration.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Speed);
            this.groupBox1.Controls.Add(this.CalculateTravelDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SelectDays);
            this.groupBox1.Controls.Add(this.SelectHours);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate travel time to the monn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output travel time";
            // 
            // OutputTravelTime
            // 
            this.OutputTravelTime.Location = new System.Drawing.Point(190, 246);
            this.OutputTravelTime.Name = "OutputTravelTime";
            this.OutputTravelTime.Size = new System.Drawing.Size(138, 22);
            this.OutputTravelTime.TabIndex = 8;
            // 
            // Feld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(450, 298);
            this.Controls.Add(this.OutputTravelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Feld";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton SelectDays;
        private System.Windows.Forms.RadioButton SelectHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Button CalculateTravelDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTravelTime;
    }
}


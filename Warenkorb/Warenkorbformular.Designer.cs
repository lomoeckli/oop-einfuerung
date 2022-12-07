namespace Warenkorb
{
    partial class Warenkorbformular
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowProducts = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dein Warenkorb";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warenkorb.Properties.Resources._160_F_68489642_CJVCVBMPhdwMRZFciRGK1JxWT1C7aaVd;
            this.pictureBox1.Location = new System.Drawing.Point(18, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 133);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ShowProducts
            // 
            this.ShowProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowProducts.Location = new System.Drawing.Point(18, 180);
            this.ShowProducts.Multiline = true;
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowProducts.Size = new System.Drawing.Size(735, 269);
            this.ShowProducts.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(603, 496);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(148, 44);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Abbrechen";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Warenkorbformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 584);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Warenkorbformular";
            this.RightToLeftLayout = true;
            this.Text = "Warenkorbformular";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ShowProducts;
        private System.Windows.Forms.Button Exit;
    }
}
﻿namespace Warenkorb
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
            this.Exit = new System.Windows.Forms.Button();
            this.ShowProducts = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 52);
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
            this.pictureBox1.Size = new System.Drawing.Size(184, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // ShowProducts
            // 
            this.ShowProducts.FormattingEnabled = true;
            this.ShowProducts.ItemHeight = 16;
            this.ShowProducts.Location = new System.Drawing.Point(18, 168);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(814, 292);
            this.ShowProducts.TabIndex = 4;
            this.ShowProducts.SelectedIndexChanged += new System.EventHandler(this.ShowProducts_SelectedIndexChanged);
            // 
            // Warenkorbformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.ShowProducts);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Warenkorbformular";
            this.RightToLeftLayout = true;
            this.Text = "Warenkorbformular";
            this.Load += new System.EventHandler(this.Warenkorbformular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox ShowProducts;
    }
}
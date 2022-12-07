namespace Warenkorb
{
    partial class Bestellformular
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WarenkorbLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumberProducts = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddProduct);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddProduct.Location = new System.Drawing.Point(199, 133);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(276, 37);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "Zum Warenkorb hinzufügen";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(199, 76);
            this.Number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 22);
            this.Number.TabIndex = 3;
            this.Number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(199, 36);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(338, 22);
            this.ProductName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkt (Name):";
            // 
            // WarenkorbLink
            // 
            this.WarenkorbLink.AutoSize = true;
            this.WarenkorbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarenkorbLink.Location = new System.Drawing.Point(506, 47);
            this.WarenkorbLink.Name = "WarenkorbLink";
            this.WarenkorbLink.Size = new System.Drawing.Size(162, 20);
            this.WarenkorbLink.TabIndex = 1;
            this.WarenkorbLink.TabStop = true;
            this.WarenkorbLink.Text = "Warenkorb anzeigen";
            this.WarenkorbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WarenkorbLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warenkorb.Properties.Resources.warenkorb;
            this.pictureBox1.Location = new System.Drawing.Point(443, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumberProducts
            // 
            this.labelNumberProducts.AutoSize = true;
            this.labelNumberProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProducts.Location = new System.Drawing.Point(412, 51);
            this.labelNumberProducts.Name = "labelNumberProducts";
            this.labelNumberProducts.Size = new System.Drawing.Size(25, 16);
            this.labelNumberProducts.TabIndex = 3;
            this.labelNumberProducts.Text = "(0)";
            // 
            // Bestellformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.labelNumberProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WarenkorbLink);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bestellformular";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel WarenkorbLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNumberProducts;
    }
}


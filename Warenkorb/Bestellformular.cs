using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class Bestellformular : Form
    {
        List<OrderItem> orderedItems = new List<OrderItem>();

        public Bestellformular()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductName.Text.Trim()))
                return;

            OrderItem item = new OrderItem();
            item.ProductName = ProductName.Text;
            item.Amount = Convert.ToInt32(Number.Value);
            orderedItems.Add(item);

            labelNumberProducts.Text = "(" + orderedItems.Count.ToString() + ")";

            ProductName.Text = "";
            ProductName.Focus();
            Number.Value = 1;
        }


        private void WarenkorbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Warenkorbformular w = new Warenkorbformular(this.orderedItems);
            w.ShowDialog();
        }

        
    }
}

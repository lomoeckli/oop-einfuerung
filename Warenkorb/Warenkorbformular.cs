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
    public partial class Warenkorbformular : Form
    {
        List<OrderItem> items;
        public Warenkorbformular(List<OrderItem> orderedItems)
        {
            InitializeComponent();

            this.items = orderedItems;
            
        }

        private void Warenkorbformular_Load(object sender, EventArgs e)
        {
            foreach (OrderItem item in items)
            {
               // muss lîstbox verwenden -> ShowProducts.Items.Add(item.Amount + " Ex." + "\t" + item.ProductName);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}

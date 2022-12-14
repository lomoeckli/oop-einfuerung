using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSimulator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));
        }
    }
}

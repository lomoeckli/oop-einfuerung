using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaechenberechnungRechteck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Berechnen_Click(object sender, EventArgs e)
        {
            Rechteck r = new Rechteck();
            r.Width = Convert.ToDouble(textBoxBreite.Text);
            r.Height = Convert.ToDouble(textBoxHoehe.Text);

            double area =  r.GetArea();
            textBoxResulltat.Text = Convert.ToString(area);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void DrawTree_Click(object sender, EventArgs e)
        {
            Tannenbaum t = new Tannenbaum();
            t.TrunkWidth = Convert.ToInt32(Trunkwidth.Text);
            t.TrunkHeight = Convert.ToInt32(TrunkHeight.Text);
            t.CrownHeight = Convert.ToInt32(CrownHeight.Text);

            string result = t.Draw();
            TreeDrawing.Text = result;
        }
    }
}

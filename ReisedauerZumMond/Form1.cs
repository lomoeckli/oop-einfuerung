using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisedauerZumMond
{
    public partial class Feld : Form
    {
        public Feld()
        {
            InitializeComponent();
        }

        private void CalculateTravelDuration_Click(object sender, EventArgs e)
        {
            int kmH = 0;
            
            Mondreise m = new Mondreise(kmH);

            m.KMH = Convert.ToInt32(Speed.Text);

            

            if (SelectDays.Checked == true)
            {
                double result = m.GetTravelDurationDays();
                OutputTravelTime.Text = Convert.ToString(result);
            }

            else if (SelectHours.Checked == true)
            {
                double result = m.GetTravelDurationHours();
                OutputTravelTime.Text = Convert.ToString(result);
            }
        }
    }
}

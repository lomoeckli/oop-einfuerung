using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisedauerZumMond
{
    internal class Mondreise
    {
        double speed;
        double kmH;
        double h;
        double d;
        int moonDistance = 384400;

        public double KMH
        {
            get { return kmH; }
            set { kmH = value; }
        }

        public Mondreise(double speed)
        {
            kmH = speed;
        }

        public double GetTravelDurationDays()
        {
            d = Math.Round((moonDistance / kmH / 24) * 100) / 100;
            return d;
        }

        public double GetTravelDurationHours()
        {
            h = Math.Round((moonDistance / kmH)*100)/100  ;
            return h;
        }
    }
}

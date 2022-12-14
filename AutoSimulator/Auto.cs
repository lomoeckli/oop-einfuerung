using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSimulator
{
    internal class Auto
    {
        string marke;
        int ps;
        int aktuelleGeschwindigkeit;
        int aktuellerGang;
        bool istMotorGestartet;

        public string Marke
        {
            get { return marke; }
            set { marke = value; }
        }
        public int PS
        {
            get { return ps; }
            set { ps = value; }
        }
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit;}
            set { aktuelleGeschwindigkeit = value; }
        }
        public int AktuellerGang
        {
            get { return aktuellerGang; }
            set { aktuellerGang = value; }
        }
        public bool IstMotorGestartet
        {
            get { return istMotorGestartet; }
            set { istMotorGestartet = value; }
        }

        public void StarteMotor()
        {

        }

        public void SchalteMotorAus()
        {

        }

        public void GibGas()
        {

        }

        public void Bremse()
        {

        }

        public void Hupe()
        {

        }
    }
}

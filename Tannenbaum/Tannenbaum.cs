using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    internal class Tannenbaum
    {
        int trunkWidth;
        int trunkHeight;
        int crownHeight;
        string result;

        public int TrunkWidth
        {
            get { return trunkWidth; }
            set { trunkWidth = value; }
        }

        public int TrunkHeight
        {
            get { return trunkHeight; }
            set { trunkHeight = value; }
        }

        public int CrownHeight
        {
            get { return crownHeight; }
            set { crownHeight = value; }
        }

        public string Draw()
        {
            for (int i = 1; i <= crownHeight; i++)
            {

                for (int j = 1; j <= crownHeight - i; j++)
                    result += " ";

                for (int j = 1; j <= (2 * i - 1); j++)
                    result += "*";

                result += "\r\n";
            }


            for (int i = 0; i < trunkHeight; i++)
            {
                for (int l = ((trunkWidth - 1) / 2) + 1; l < crownHeight; l++)
                {
                    result += " ";
                }
                result += "";

                for (int j = 1; j < trunkWidth; j++)
                {
                    result += "*";
                }
                result += "\r\n";
            }
            result += "\r\n";

            return result;
        }
    }
}

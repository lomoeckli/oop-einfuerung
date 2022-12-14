using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaechenberechnungRechteck
{
    internal class Rechteck
    {
        double height;
        double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
           double area = height * width;
           return area;
        }

    }
}

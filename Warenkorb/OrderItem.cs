using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class OrderItem 
    {

        public string ProductName { get; set; }

        public int Amount { get; set; }


        public override string ToString()
        {
            return this.Amount.ToString() + " Ex.\t" + this.ProductName;
        }
    }
}

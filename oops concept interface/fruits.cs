using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Interface is similar to abstract class and has only empty bodies such as empty properties and methods*/

namespace Fruits
{
    interface fruits
    {
        /* It doesn't have fields i.e variables */
        string getPrice();
        void setPrice(double price);

    }
}

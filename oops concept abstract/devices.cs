using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    /**************************************************************************
     * Abstract class can be used as template for another class by overriding *
     **************************************************************************/
    abstract class devices
    {
        public string brand;

        public abstract void setBrand(string brand);

        public abstract void getBrand();

    }
}

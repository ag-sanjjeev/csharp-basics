using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    class device
    {
        private string name;
        public string Name
        {
            get; set;
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}

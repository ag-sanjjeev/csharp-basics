using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fruits
{
    class apple : fruits
    {
        public double fruitPrice;
        public void setPrice(double price)
        {
            this.fruitPrice = price;
        }

        public string getPrice()
        {
            return $"The apple price is : {this.fruitPrice}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que14
{
    public class Car:Owner
    {
        internal double price;
        private string bodyStyle
        {
            get
            {
                return BodyStyle;
            }
        }
        public string BodyStyle;


        public bool ValidateBodyStyle(string bodyStyle)
        {
            if(bodyStyle == "SUV" || bodyStyle == "Sedan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePrice()
        {
            if(bodyStyle == "SUV")
            {
                price = price - (price * 10 / 100);
                return price;
            }
            else if(bodyStyle == "Sedan")
            {
                price = price - (price * 25 / 100);
                return price;
            }
            return 0;
        }
        public void setOwnerName(string name)
        {
            ownerName = name;
        }
    }
}

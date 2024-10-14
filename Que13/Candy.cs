using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que13
{
    public class Candy
    {
        public string Flavour;
        public int Quantity;
        public int PricePerPiece;
        public double TotalPrice;
        public double Discount;
        public bool ValidateCandyFlavour()
        {
            if(Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

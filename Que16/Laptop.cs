using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que16
{
    public class Laptop : Computer
    {
        public int DisplaySize;
        public int BatteryVolt;
        public double LaptopPriceCalculation()
        {
            //int ramPrice = 200;
            //int hardDisk = 1500;
            //int graphicCard = 2500;
            //int battery = 20;
            //int display = 250;
            if(Processor == "i3")
            {
                double laptopPrice = 2500 + (200 * RamSize) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 20) + (BatteryVolt * 250);
                return laptopPrice;
            }
            else if (Processor == "i5")
            {
                double laptopPrice = 5000 + (200 * RamSize) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 20) + (BatteryVolt * 250);
                return laptopPrice;
            }
            else
            {
                double laptopPrice = 6500 + (200 * RamSize) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 20) + (BatteryVolt * 250);
                return laptopPrice;
            }
            
        }
    }
}

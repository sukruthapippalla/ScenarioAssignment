using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que16
{
    public class Desktop : Computer
    {
        public int MonitorSize;
        public int PowerSupplyVolt;
        public double DesktopPriceCalculation()
        {
            //int ramPrice = 200;
            //int hardDisk = 1500;
            //int graphicCard = 2500;
            //int powerSupply = 20;
            //int monitor = 250;
            if (Processor == "i3")
            {
                double desktopPrice = 1500 + 
                    (RamSize * 200) + 
                    (HardDiskSize * 1500) + 
                    (GraphicCard * 2500) + 
                    (MonitorSize * 250) + 
                    (PowerSupplyVolt * 20);
                return desktopPrice;
            }
            else if(Processor == "i5")
            {
                double desktopPrice = 3000 + 
                    (RamSize * 200) + 
                    (HardDiskSize * 1500) + 
                    (GraphicCard * 2500) + 
                    (MonitorSize * 250) + 
                    (PowerSupplyVolt * 20);
                return desktopPrice;
            }
            else
            {
                double desktopPrice = 4500 + 
                    (RamSize * 200) + 
                    (HardDiskSize * 1500) + 
                    (GraphicCard * 2500) + 
                    (MonitorSize * 250) + 
                    (PowerSupplyVolt * 20);
                return desktopPrice;
            }
            
        }
    }
}

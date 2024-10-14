namespace Que16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Desktop");
            Console.WriteLine("2.Laptop");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Desktop desktop = new Desktop();

                        Console.WriteLine("Enter the processor");
                        desktop.Processor = Console.ReadLine();

                        Console.WriteLine("Enter the ram size");
                        desktop.RamSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the hard disk size");
                        desktop.HardDiskSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the graphic card size");
                        desktop.GraphicCard = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the monitor size");
                        desktop.MonitorSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the power supply volt");
                        desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

                        double result = desktop.DesktopPriceCalculation();

                        Console.WriteLine($"Desktop price is {result}");

                        break;
                    }
                case 2:
                    {
                        Laptop laptop = new Laptop();

                        Console.WriteLine("Enter the processor");
                        laptop.Processor = Console.ReadLine();

                        Console.WriteLine("Enter the ram size");
                        laptop.RamSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the hard disk size");
                        laptop.HardDiskSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the graphic card size");
                        laptop.GraphicCard = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the display size");
                        laptop.DisplaySize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the battery volt");
                        laptop.BatteryVolt = int.Parse(Console.ReadLine());
  
                        double result = laptop.LaptopPriceCalculation();

                        Console.WriteLine($"Laptop price is {result}");

                        break;
                    }
            }
        }
    }
}

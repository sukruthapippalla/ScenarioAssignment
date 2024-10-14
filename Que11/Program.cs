namespace Que11
{
    public class Program
    {
        public object CalculateDiscountedPrice(object totalCost)
        {
            double tCost = (Double)totalCost;
            double Discount = 0;
            double DiscountedPrice = tCost - Discount;
            if(tCost >= 100 && tCost <= 500)
            {
                Discount = tCost * 5 / 100;
                DiscountedPrice = tCost - Discount;
            }
            else if(tCost > 500 && tCost <= 1000)
            {
                Discount = tCost * 15 / 100;
                DiscountedPrice = tCost - Discount;
            }
            else if(tCost > 1000)
            {
                Discount = tCost * 30 / 100;
                DiscountedPrice = tCost - Discount;
            }
            return DiscountedPrice;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the total cost");
            object totalCost = double.Parse(Console.ReadLine());

            object result = program.CalculateDiscountedPrice(totalCost);

            Console.WriteLine($"Price after discount is {result}");
        }
    }
}

namespace Que13
{
    public class Program
    {
        public Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
            if(candy.Flavour == "Strawberry")
            {
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 15 / 100);
            }
            else if (candy.Flavour == "Lemon")
            {
                
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 10 / 100);
            }
            else if (candy.Flavour == "Mint")
            {
                
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 5 / 100);
            }
            return candy;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Candy candy = new Candy();

            Console.WriteLine("Enter the flavour");
            candy.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity");
            candy.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per piece");
            candy.PricePerPiece = int.Parse(Console.ReadLine());

            bool validation = candy.ValidateCandyFlavour();

            if (validation) 
            {
                Candy result = program.CalculateDiscountedPrice(candy);
                Console.WriteLine($"Flavour : {result.Flavour}");
                Console.WriteLine($"Quantity : {result.Quantity}");
                Console.WriteLine($"Price per Piece : {result.PricePerPiece}");
                Console.WriteLine($"Total Price : {result.TotalPrice}");
                Console.WriteLine($"Discount Price : {result.Discount}");
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }

        }
    }
}

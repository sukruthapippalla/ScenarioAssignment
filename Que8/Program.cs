namespace Que8
{
    public class Program
    {
        public string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] productInfo = details[i].Split(':');
                if (int.Parse(productInfo[0]) == id)
                {
                    productInfo[2] = amount.ToString();
                    return productInfo[1] + " " + productInfo[2];
                }
            }
            return " ";
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the number of products");
            int noOfProducts = int.Parse(Console.ReadLine());

            string[] products = new string[noOfProducts];

            Console.WriteLine("Enter the product details");
            for (int i = 0; i < noOfProducts; i++)
            {
                products[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the product id");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount to update");
            double updatedPrice = double.Parse(Console.ReadLine());

            string result = program.UpdatePrice(products, productId, updatedPrice);

            if(result == " ")
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

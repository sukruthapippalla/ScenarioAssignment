namespace Que14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Enter the car body style:");
            car.BodyStyle = Console.ReadLine();

            Console.WriteLine("Enter the price: ");
            car.price = double.Parse(Console.ReadLine());

            bool validation = car.ValidateBodyStyle(car.BodyStyle);
            if (validation)
            {
                double result = car.CalculatePrice();
                Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${result}");
            }
            
        }
    }
}

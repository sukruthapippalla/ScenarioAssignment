namespace Que1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a float value");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a double value");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Enter a long value");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter a string");
            string b = Console.ReadLine();

            Console.WriteLine($"int: {x}");
            Console.WriteLine($"float: {y}");
            Console.WriteLine($"double: {z}");
            Console.WriteLine($"long: {a}");
        }
    }
}

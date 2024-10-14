namespace Que3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            do
            {
                Console.WriteLine($"{x} {y}");
                y++;
                if (y > 2)
                {
                    y = 1;
                    x++;
                }

            } while (x <= 5);
        }
    }
}

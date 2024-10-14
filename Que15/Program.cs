namespace Que15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the number of pages");
            int numPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the due date");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the return date");
            DateTime returnedDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days to read");
            int daysToRead = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the daily late feeRate");
            double dailyLateFeeRate = double.Parse(Console.ReadLine());

            Book book = new Book(title, author, numPages, dueDate, returnedDate);

            double resPages = book.AveragePagesReadPerDay(daysToRead);
            Console.WriteLine($"Average Pages Read Per Day : {Math.Round(resPages)}");

            double lateFee = book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Late Fee : {lateFee}");
        }
    }
}

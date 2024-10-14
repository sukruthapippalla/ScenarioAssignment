namespace Que2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the movie name");
            string x = Console.ReadLine();
            Console.Write("Enter the ticket id");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seat number");
            string z = Console.ReadLine();
            Movie movieP = new Movie();
            Movie result = movieP.ReturnMovieDetails(x, y, z);
            Console.WriteLine($"Movie name : {Movie.name}");
            Console.WriteLine($"Ticket id : {result.ticketId}");
            Console.WriteLine($"Seat number : {result.seatNumber}");
        }
    }
}

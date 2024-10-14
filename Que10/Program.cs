namespace Que10
{
    public class Program
    {
        public string FindWhoGotMaximumPoints(int[][] points)
        {
            int[] totalPoints = new int[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                int sum = 0;
                for(int j =0; j < points[i].Length; j++)
                {
                    sum += points[i][j];
                }
                totalPoints[i] = sum;
            }

            int res = 0;

            for (int i = 0; i < totalPoints.Length; i++)
            {
                if (totalPoints[i] > totalPoints[res])
                {
                    res = i;
                }
            }

            return $"Student {res + 1} got maximum points.";
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the number of students");
            int noOfStudents = int.Parse(Console.ReadLine());

            int[][] points = new int [noOfStudents][];

            for (int i = 0; i < noOfStudents; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i+1}");
                int n = int.Parse(Console.ReadLine());

                points[i] = new int[n];

                Console.WriteLine($"Enter the student {i+1} points ");
                for (int j = 0; j < n; j++)
                {
                    points[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(program.FindWhoGotMaximumPoints(points));
        }
    }
}

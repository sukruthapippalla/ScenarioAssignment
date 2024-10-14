namespace Que9
{
    public class Program
    {
        public int[] FindStudentRank(int[,] stdMarks)
        {
            int noOfStudents = stdMarks.GetLength(0);
            int[] totalMarks = new int[noOfStudents];
            int[] ranks = new int[noOfStudents];

            for (int i = 0; i < noOfStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += stdMarks[i, j];
                }
                totalMarks[i] = sum;
            }

            for(int i = 0;i < noOfStudents; i++)
            {
                int rank = 1;
                for (int j = 0;j < noOfStudents; j++)
                {
                    if (totalMarks[j] > totalMarks[i])
                    {
                        rank++;
                    }
                }
                ranks[i] = rank;
            }
            return ranks;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the number of students");
            int noOfStudents = int.Parse(Console.ReadLine());
            int[,] stuMarks = new int[noOfStudents,5];
            for(int i = 0; i < noOfStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i+1}");
                for(int j = 0; j < 5; j++)
                {
                    stuMarks[i,j] = int.Parse(Console.ReadLine());
                }
            }
            int[] resultArr = program.FindStudentRank(stuMarks);
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.WriteLine($"Rank of student {i+1} is {resultArr[i]}");
            }
        }
    }
}

using System.Text;

namespace Que7
{
    public class Program
    {
        public StringBuilder FindExponential(int number)
        {
            StringBuilder obj = new StringBuilder("Exponential is ");
            obj.Append(number.ToString("E"));
            return obj;
        }
        public StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
            StringBuilder res = new StringBuilder(sentence.Replace(word1, word2));
            return res;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("1.Find Exponential");
            Console.WriteLine("2.Replace Word");
            Console.WriteLine("Choose the option");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the number");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(program.FindExponential(n));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the sentence");
                string sentence = Console.ReadLine();
                Console.WriteLine("Enter the word 1");
                string word1 = Console.ReadLine();
                Console.WriteLine("Enter the word 2");
                string word2 = Console.ReadLine();

                Console.WriteLine(program.ReplaceWord(sentence,word1,word2));
            }
        }
    }
}

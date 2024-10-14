using System.Text;

namespace Que6
{
    public class Program
    {
        public StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int position = 0;
            char[] chArr = word1.ToString().ToCharArray();
            for(int i = 0; i < chArr.Length; i++)
            {
                if(ch == chArr[i])
                {
                    position = i;
                    break;
                }
            }
            word1.Insert(position, word2);
            return word1;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter the word 1");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter the character to search");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the word 2");
            string word2 = Console.ReadLine();

            StringBuilder result = program.WordInserting(word1, ch, word2);
            Console.WriteLine(result);
        }
    }
}

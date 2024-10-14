namespace Que12
{
    public class Program
    {
        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            HashSet<char> repeatedChar = new HashSet<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (repeatedChar.Contains(chars[i]))
                {
                    chars[i] = specialChar;
                }
                else
                {
                    repeatedChar.Add(chars[i]);
                }
            }
        }
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the array size");
            int aSize = int.Parse(Console.ReadLine());

            char[] chars = new char[aSize];

            Console.WriteLine("Enter the characters");
            for (int i = 0; i < aSize; i++) 
            {
                chars[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the special character");
            char specialChar = char.Parse(Console.ReadLine());

            program.ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
            

        }
    }
}

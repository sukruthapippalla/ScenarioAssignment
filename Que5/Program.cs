namespace Que5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            string[] words = input.Split(':');

            if (words.Length >= 15)
            {
                Console.WriteLine("Invalid length");
            }
            
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word]=1;
                }
            }

            foreach(var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key.ToUpper()}:{entry.Value}");
            }
        }
    }
}

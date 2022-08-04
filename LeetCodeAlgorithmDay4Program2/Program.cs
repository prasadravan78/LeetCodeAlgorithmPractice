namespace LeetCodeAlgorithmDay4Program2
{
    internal class ReverseWordsInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Hello World"));
            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            var head = 0;
            var tail = s.Length -1;
            var charArray = s.ToCharArray();

            while (head < tail)
            {
                (charArray[tail], charArray[head]) = (charArray[head], charArray[tail]);

                head++;
                tail--;
            }

            s = new string(charArray);

            var words = s.Split(' ');

            head = 0;
            tail = words.Length - 1;

            while (head < tail)
            {
                (words[tail], words[head]) = (words[head], words[tail]);

                head++;
                tail--;
            }

            return string.Join(" ", words);
        }
    }
}
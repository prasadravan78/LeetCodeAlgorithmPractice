namespace LeetCodeAlgorithmDay5Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.ReadLine();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var chars = new HashSet<char>();
            int max = 0;
            int i = 0;
            int j = 0;

            while (i < s.Length)
            {
                if (!chars.Contains(s[i]))
                {
                    chars.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, chars.Count);
                    chars.Remove(s[j]);
                    j++;
                }
            }

            max = Math.Max(max, chars.Count);

            return max;
        }
    }
}
namespace LeetCodeAlgorithmDay5Program2
{
    internal class PermutationString
    {
        static void Main(string[] args)
        {
            if (CheckInclusion("abe", "eidebaoo"))
            {
                Console.WriteLine("Permutation in String");
            }

            Console.ReadLine();
        }

        public static bool CheckInclusion(string s1, string s2)
        {
            int[] freq1 = new int[26];
            int[] freq2 = new int[26];
            int windowStart = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                freq1[s1[i] - 'a']++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                freq2[s2[i] - 'a']++;
                if (i - windowStart + 1 > s1.Length)
                {
                    freq2[s2[windowStart++] - 'a']--;
                }

                if (i - windowStart + 1 == s1.Length && IsAnagram(freq1, freq2)) return true;
            }

            return false;
        }

        private static bool IsAnagram(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}
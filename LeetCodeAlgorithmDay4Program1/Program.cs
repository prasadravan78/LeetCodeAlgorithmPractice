namespace LeetCodeAlgorithmDay4Program1
{
    internal class ReverseStringProgram
    {
        static void Main(string[] args)
        {
            ReverseString("Hello".ToCharArray());
            Console.ReadLine();
        }

        public static void ReverseString(char[] s)
        {
            var head = 0;
            var tail = s.Length -1;

            while (head < tail)
            {
                (s[tail], s[head]) = (s[head], s[tail]);

                head++;
                tail--;
            }

            Console.WriteLine(new String(s));
        }
    }
}
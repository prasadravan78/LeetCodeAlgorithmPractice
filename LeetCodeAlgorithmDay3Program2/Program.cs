namespace LeetCodeAlgorithmDay3Program2
{
    internal class TargetTwoSum
    {
        static void Main(string[] args)
        {
            var output = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            var start = 0;
            var end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] + numbers[end] == target)
                {
                    return new int[2] { ++start, ++end };
                }
                else if (numbers[start] + numbers[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}
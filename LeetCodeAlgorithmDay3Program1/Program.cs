namespace LeetCodeAlgorithmDay3Program1
{
    internal class MoveZero
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] { 1, 0, 3, 0, 12 });
            Console.ReadLine();
        }

        public static void MoveZeroes(int[] nums)
        {
            var zeroIndex = 0;
            var nonZeroIndex = 0;

            while (nonZeroIndex < nums.Length && zeroIndex < nums.Length)
            {
                if (nums[zeroIndex] == 0)
                {
                    if (nonZeroIndex > zeroIndex)
                    {
                        nums[zeroIndex] = nums[nonZeroIndex];
                        nums[nonZeroIndex] = 0;
                        nonZeroIndex++;
                    }
                    else
                    {
                        nonZeroIndex++;
                    }
                }
                else
                {
                    zeroIndex++;
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
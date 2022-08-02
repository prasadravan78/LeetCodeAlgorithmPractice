namespace LeetCodeAlgorithmDay2Program1
{
    internal class SquaresOfSorted
    {
        static void Main(string[] args)
        {
            var sortedArray = SortedSquares(new int[] { -4, -2, 0, 5 });

            foreach (int i in sortedArray)
            { 
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static int[] SortedSquares(int[] nums)
        {
            var squared = new int[nums.Length];

            var beginIndex = 0;
            var endIndex = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[beginIndex]) > Math.Abs(nums[endIndex]))
                {
                    squared[i] = nums[beginIndex] * nums[beginIndex];
                    beginIndex++;
                }
                else
                {
                    squared[i] = nums[endIndex] * nums[endIndex];
                    endIndex--;
                }
            }  

            return squared;
        }
    }
}
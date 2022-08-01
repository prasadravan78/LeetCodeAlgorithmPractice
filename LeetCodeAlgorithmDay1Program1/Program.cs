namespace LeetCodeAlgorithmDay1Program1
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 5, 6 };

            Console.WriteLine(Search(nums, 9));
            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            int minIndex = 0;
            int maxIndex = nums.Length - 1;

            while (minIndex <= maxIndex)
            {
                int midIndex = (minIndex + maxIndex) / 2;

                if (target == nums[midIndex])
                {
                    return midIndex;
                }
                else if (target < nums[midIndex])
                {
                    maxIndex = midIndex - 1;
                }
                else
                {
                    minIndex = midIndex + 1;
                }
            }

            return -1;
        }
    }
}
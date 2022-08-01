namespace LeetCodeAlgorithmDay1Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 6 };
            Console.WriteLine(SearchInsert(nums, 6));
            Console.ReadLine();
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int minIndex = 0;
            int maxIndex = nums.Length - 1;

            while (minIndex <= maxIndex)
            { 
                int midIndex = minIndex + (maxIndex - minIndex) /2;

                if (nums[midIndex] == target)
                {
                    return midIndex;
                }
                else if (nums[midIndex] > target)
                {
                    maxIndex = midIndex - 1;
                }
                else
                {
                    minIndex = midIndex + 1;
                }
            }
            
            return minIndex;
        }
    }
}
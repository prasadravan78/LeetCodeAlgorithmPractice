namespace LeetCodeAlgorithmDay2Program2
{
    internal class RotateArray
    {
        static void Main(string[] args)
        {
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
            Console.ReadLine();
        }

        public static void Rotate(int[] nums, int k)
        {
            var returnArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                returnArray[(i + k) % nums.Length] = nums[i];
            }
            
            foreach (int i in returnArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
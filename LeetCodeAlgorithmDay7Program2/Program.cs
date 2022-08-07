namespace LeetCodeAlgorithmDay7Program2
{
    internal class IsLandArea
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[2][];
            grid[0] = new int[3] { 0, 0, 0 };
            grid[1] = new int[3] { 1, 1, 0 };

            Console.WriteLine(MaxAreaOfIsland(grid));
        }

        public static int MaxAreaOfIsland(int[][] grid)
        {
            var maxArea = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        grid[i][j] = 0;
                        maxArea = Math.Max(maxArea, GetMaxArea(grid, i, j));

                    }
                }
            }

            return maxArea;
        }

        public static int GetMaxArea(int[][] grid, int row, int col)
        {
            var totalArea = 1;

            if (row - 1 > 0 && grid[row - 1][col] > 0)
            {
                grid[row - 1][col] = 0;
                totalArea += GetMaxArea(grid, row - 1, col);
            }

            if (row + 1 < grid.Length && grid[row + 1][col] > 0)
            {
                grid[row + 1][col] = 0;
                totalArea += GetMaxArea(grid, row + 1, col);
            }

            if (col + 1 < grid[0].Length && grid[row][col + 1] > 0)
            {
                grid[row][col + 1] = 0;
                totalArea += GetMaxArea(grid, row, col + 1);
            }

            if (col - 1 > 0 && grid[row][col - 1] > 0)
            {
                grid[row][col - 1] = 0;
                totalArea += GetMaxArea(grid, row, col - 1);
            }

            return totalArea;
        }
    }
}
namespace LeetCodeAlgorithmDay9Program2
{
    internal class RottingOranges
    {
        static void Main(string[] args)
        {
            var grid = new int[3][];

            grid[0] = new int[] { 2, 1, 1 };
            grid[1] = new int[] { 1, 1, 0 };
            grid[2] = new int[] { 0, 1, 1 };

            Console.WriteLine(OrangesRotting(grid));
            Console.ReadLine();
        }

        public static int OrangesRotting(int[][] grid)
        {
            int freshCount = 0;
            var queue = new Queue<(int, int)>();
            var directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        freshCount++;
                    }
                    else if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            if (freshCount == 0)
            {
                return 0;
            }

            var minutes = -1;

            while (queue.Any())
            {
                var count = queue.Count;

                while (count > 0)
                {
                    var (i, j) = queue.Dequeue();

                    foreach (var dir in directions)
                    {
                        var (newI, newJ) = (i + dir[0], j + dir[1]);

                        if (newI >= 0 && newJ >= 0 && newI < grid.Length && newJ < grid[0].Length && grid[newI][newJ] == 1)
                        {
                            queue.Enqueue((newI, newJ));
                            grid[newI][newJ] = 2;
                            freshCount--;
                        }
                    }

                    count--;
                }

                minutes++;
            }

            return freshCount > 0 ? -1 : minutes;
        }
    }
}
namespace LeetCodeAlgorithmDay9Program1
{
    internal class DistanceToZero
    {
        static void Main(string[] args)
        {
            var matrix = new int[3][];

            matrix[0] = new int[] { 1, 1, 1 };
            matrix[1] = new int[] { 1, 0, 1 };
            matrix[2] = new int[] { 1, 1, 1 };

            var result = UpdateMatrix(matrix);
            Console.ReadLine();
        }

        public static int[][] UpdateMatrix(int[][] mat)
        {
            var list = new List<(int, int)>();
            var directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        list.Add((i, j));
                    }
                    else
                    {
                        mat[i][j] = -1;
                    }
                }
            }

            var step = 1;

            while (list.Count > 0)
            {
                var newList = new List<(int, int)>();

                foreach (var (i, j) in list)
                {
                    foreach (var dir in directions)
                    {
                        var newI = i + dir[0];
                        var newJ = j + dir[1];

                        if (newI >= 0 && newI < mat.Length && newJ >= 0 && newJ < mat[0].Length && mat[newI][newJ] == -1)
                        {
                            newList.Add((newI, newJ));
                            mat[newI][newJ] = step;
                        }
                    }
                }

                list = newList;
                step++;
            }

            return mat;
        }
    }
}
namespace LeetCodeAlgorithmDay7Program1
{
    internal class FloodFillDFS
    {
        static void Main(string[] args)
        {
            int[][] image = new int[2][];
            image[0] = new int[3] { 0, 0, 0 };
            image[1] = new int[3] { 0, 1, 0 };

            Console.WriteLine(FloodFill(image, 0, 0, 2));
            Console.ReadLine();
        }

        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var queue = new Queue<int[]>();
            var existingColor = image[sr][sc];

            if (existingColor == color)
            {
                return image;
            }

            image[sr][sc] = color;
            queue.Enqueue(new int[] { sr, sc });

            while (queue.Count() > 0)
            {
                var dequewed = queue.Dequeue();

                if (dequewed[0] - 1 > -1 && image[dequewed[0] - 1][dequewed[1]] == existingColor)
                {
                    image[dequewed[0] - 1][dequewed[1]] = color;
                    queue.Enqueue(new int[] { dequewed[0] - 1, dequewed[1] });
                }
                if (dequewed[1] - 1 > -1 && image[dequewed[0]][dequewed[1] - 1] == existingColor)
                {
                    image[dequewed[0]][dequewed[1] - 1] = color;
                    queue.Enqueue(new int[] { dequewed[0], dequewed[1] - 1 });
                }

                if (dequewed[0] + 1 < image.Length && image[dequewed[0] + 1][dequewed[1]] == existingColor)
                {
                    image[dequewed[0] + 1][dequewed[1]] = color;
                    queue.Enqueue(new int[] { dequewed[0] + 1, dequewed[1] });
                }

                if (dequewed[1] + 1 < image[0].Length && image[dequewed[0]][dequewed[1] + 1] == existingColor)
                {
                    image[dequewed[0]][dequewed[1] + 1] = color;
                    queue.Enqueue(new int[] { dequewed[0], dequewed[1] + 1 });
                }
            }

            return image;
        }
    }
}
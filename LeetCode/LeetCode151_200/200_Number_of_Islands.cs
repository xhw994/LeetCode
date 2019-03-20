using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static int NumIslands(char[,] grid)
        {
            if (grid == null)
            {
                return 0;
            }

            int c = 0;
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    if (grid[y, x] == '0')
                    {
                        continue;
                    }

                    c++;
                    Traverse(x, y);
                }
            }

            void Traverse(int x, int y)
            {
                grid[y, x] = '0';
                // right
                if (x < cols - 1 && grid[y, x + 1] == '1')
                {
                    Traverse(x + 1, y);
                }
                // down
                if (y < rows - 1 && grid[y + 1, x] == '1')
                {
                    Traverse(x, y + 1);
                }
                // left
                if (x > 0 && grid[y, x - 1] == '1')
                {
                    Traverse(x - 1, y);
                }
                // up
                if (y > 0 && grid[y - 1, x] == '1')
                {
                    Traverse(x, y - 1);
                }
            }

            return c;
        }

        // Queue is really slow, smh
        private static int UsingQueue(char[,] grid)
        {
            if (grid == null)
            {
                return 0;
            }

            int c = 0;
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            Queue<(int, int)> q = new Queue<(int, int)>();

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    if (grid[y, x] == '0')
                    {
                        continue;
                    }
                    c++;
                    q.Enqueue((x, y));
                    while (q.Count != 0)
                    {
                        for (int i = 0; i < q.Count; i++)
                        {
                            (int X, int Y) = q.Dequeue();
                            grid[Y, X] = '0';

                            // right
                            if (X < cols - 1 && grid[Y, X + 1] == '1')
                            {
                                q.Enqueue((X + 1, Y));
                            }
                            // down
                            if (Y < rows - 1 && grid[Y + 1, X] == '1')
                            {
                                q.Enqueue((X, Y + 1));
                            }
                            // left
                            if (X > 0 && grid[Y, X - 1] == '1')
                            {
                                q.Enqueue((X - 1, Y));
                            }
                            // up
                            if (Y > 0 && grid[Y - 1, X] == '1')
                            {
                                q.Enqueue((X, Y - 1));
                            }
                        }
                    }
                }
            }

            return c;
        }
    }
}

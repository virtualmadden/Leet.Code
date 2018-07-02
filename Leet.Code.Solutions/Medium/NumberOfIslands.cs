namespace Leet.Code.Solutions.Medium
{
    public class NumberOfIslandsSolution
    {
        public int NumIslands(char[,] grid)
        {
            var islands = 0;

            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Equals('1'))
                    {
                        islands++;

                        DepthFirstSearch(grid, i, j);
                    }
                }
            }

            return islands;
        }

        private void DepthFirstSearch(char[,] grid, int x, int y)
        {
            if (x < 0 || y < 0 || x > grid.GetLength(0) - 1 || y > grid.GetLength(1) - 1)
            {
                return;
            }

            switch (grid[x, y])
            {
                case '0':
                case 'v':
                    return;
            }

            grid[x, y] = 'v';

            DepthFirstSearch(grid, x - 1, y);
            DepthFirstSearch(grid, x + 1, y);
            DepthFirstSearch(grid, x, y - 1);
            DepthFirstSearch(grid, x, y + 1);
        }
    }
}
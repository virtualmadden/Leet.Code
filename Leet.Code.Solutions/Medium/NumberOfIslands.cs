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
                    }

                    if (grid[i, j].Equals('0'))
                    {
                    }
                }
            }

            return islands;
        }
    }
}
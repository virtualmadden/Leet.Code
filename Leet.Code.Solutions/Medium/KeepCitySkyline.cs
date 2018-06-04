using System.Linq;

namespace Leet.Code.Solutions.Medium
{
    public class KeepCitySkylineSolution
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var sum = 0;

            var gridSize = grid[0].Length;

            for (var i = 0; i < gridSize; i++)
            {
                var horizontalMax = grid[i].Max(x => x);

                for (var j = 0; j < grid[i].Length; j++)
                {
                    var verticalMax = 0;

                    var k = j;
                    for (var l = 0; l < grid[k].Length; l++)
                    {
                        if (grid[l][k] > verticalMax)
                        {
                            verticalMax = grid[l][k];
                        }
                    }

                    if (horizontalMax > verticalMax)
                    {
                        sum += verticalMax - grid[i][j];
                        grid[i][j] = verticalMax;
                    }
                    else if (horizontalMax < verticalMax)
                    {
                        sum += horizontalMax - grid[i][j];
                        grid[i][j] = horizontalMax;
                    }
                    else if(horizontalMax == verticalMax && !grid[i][j].Equals(horizontalMax))
                    {
                        sum += horizontalMax - grid[i][j];
                        grid[i][j] = horizontalMax;
                    }
                    else
                    {
                        sum += 0;
                    }
                }
            }

            return sum;
        }
    }
}
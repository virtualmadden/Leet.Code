using System.Linq;

namespace Leet.Code.Solutions.Easy
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var numOfJewels = 0;

            foreach (var stone in stones)
            {
                if (jewels.Any(x => x.Equals(stone)))
                {
                    numOfJewels++;
                }
            }

            return numOfJewels;
        }
    }
}
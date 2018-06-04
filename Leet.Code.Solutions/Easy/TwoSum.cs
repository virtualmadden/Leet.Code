namespace Leet.Code.Solutions.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            for (var i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];

                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j].Equals(value))
                    {
                        result[0] = i;
                        result[1] = j;

                        break;
                    }
                }
            }

            return result;
        }
    }
}
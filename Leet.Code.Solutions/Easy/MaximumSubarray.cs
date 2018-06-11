namespace Leet.Code.Solutions.Easy
{
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            var result = nums[0];

            if (nums.Length > 1)
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    var total = nums[i];

                    if (total > result)
                    {
                        result = total;
                    }

                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        total += nums[j];

                        if (total > result)
                        {
                            result = total;
                        }
                    }

                    if (total > result)
                    {
                        result = total;
                    }
                }
            }

            return result;
        }
    }
}
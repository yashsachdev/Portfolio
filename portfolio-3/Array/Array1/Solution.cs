using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            int max_sum = 0;
            int curr_min = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length ; i++)
            {
                for (int j = nums.Length-1; j > 0 ; j--)
                {
                    curr_min = Math.Min(nums[i], nums[j]);
                    sum = sum + curr_min;
                    max_sum = Math.Max(sum, max_sum);

                }
            }
            return max_sum;
        }
    }
}

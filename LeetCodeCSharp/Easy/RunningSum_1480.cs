using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Easy
{
    public class RunningSum_1480
    {
        public int[] RunningSum(int[] nums)
        {
            for (int iCount = 1; iCount <= nums.Length - 1; iCount++)
            {
                nums[iCount] = nums[iCount] + nums[iCount - 1];
            }

            return nums;
        }
    }
}

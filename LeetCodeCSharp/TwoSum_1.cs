using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp {
    public class TwoSum_1 {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dAns = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dAns.ContainsKey(nums[i]))
                {
                    return new int[2] { dAns[nums[i]], i };
                }

                if (!dAns.ContainsKey(target - nums[i]))
                    dAns.Add(target - nums[i], i);
            }

            return new int[2];
        }
    }
}

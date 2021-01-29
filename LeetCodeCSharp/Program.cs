using LeetCodeCSharp.Easy;
using LeetCodeCSharp.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- TwoSum_1 --
            //TwoSum_1 oTest = new TwoSum_1();
            //int[] nums = new int[4] { 2, 7, 11, 15 };
            //int target = 9;
            //int[] aAns = oTest.TwoSum(nums, target);
            #endregion

            #region -- LeetcodeBank_1716 --
            //LeetcodeBank_1716 oTest = new LeetcodeBank_1716();
            //int iAns = oTest.TotalMoney(20); 
            #endregion

            #region -- RunningSum_1480 --
            //RunningSum_1480 oTest = new RunningSum_1480();
            //int[] nums = new int[4] { 1, 2, 3, 4 };
            //int[] aAns = oTest.RunningSum(nums); 
            #endregion

            #region -- SubrectangleQueries_1476 --
            //int[][] aArray = new int[][] { new int[] { 1, 2, 1 }, new int[] { 4, 3, 4 }, new int[] { 3, 2, 1 }, new int[] { 1, 1, 1 } };
            //SubrectangleQueries_1476 oTest = new SubrectangleQueries_1476(aArray);
            //oTest.GetValue(0, 2);
            //oTest.UpdateSubrectangle(0, 0, 3, 2, 5);
            //oTest.GetValue(0, 2);
            //oTest.GetValue(3, 1);
            //oTest.UpdateSubrectangle(3, 0, 3, 2, 10);
            //oTest.GetValue(3, 1);
            //oTest.GetValue(0, 2);
            #endregion

            #region -- RunningSum_1480 --
            //MaximumBinaryTree_654 oTest = new MaximumBinaryTree_654();
            //int[] nums = new int[6] { 3, 2, 1, 6, 0, 5 };
            //oTest.ConstructMaximumBinaryTree(nums);
            #endregion

            #region -- UglyNumber_263 --
            UglyNumber_263 oTest = new UglyNumber_263();
            int nums = 6;
            oTest.IsUgly(nums);
            #endregion
        }
    }
}

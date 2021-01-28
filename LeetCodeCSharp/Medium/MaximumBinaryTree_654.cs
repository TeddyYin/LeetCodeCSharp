using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Medium
{
    class MaximumBinaryTree_654
    {
        int[] aSign;

        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            TreeNode TNAns = new TreeNode();

            aSign = nums;

            int iMax = aSign.Max();
            int iMaxIndex = Array.IndexOf(aSign, iMax);

            TNAns.val = iMax;
            aSign[iMaxIndex] = -1;

            TNAns.left = fnGetLeftNode(TNAns, iMaxIndex);
            TNAns.right = fnGetRightNode(TNAns, iMaxIndex);

            return TNAns;
        }

        #region -- fnGetLeftNode --
        private TreeNode fnGetLeftNode(TreeNode TNNode, int iMaxIndex)
        {
            int iStart = fnGetStartIndex(iMaxIndex);

            List<int> lLeft = fnGetListByArrayStartAndEnd(iStart, iMaxIndex);

            if (lLeft.Count > 0)
            {
                int iMax = lLeft.Max();
                iMaxIndex = Array.IndexOf(aSign, iMax);

                TreeNode TNLeft = new TreeNode();
                TNLeft.val = iMax;
                aSign[iMaxIndex] = -1;
                TNLeft.left = fnGetLeftNode(TNNode, iMaxIndex);
                TNLeft.right = fnGetRightNode(TNNode, iMaxIndex);

                return TNLeft;
            }

            return null;
        }
        #endregion

        #region -- fnGetRightNode --
        private TreeNode fnGetRightNode(TreeNode TNNode, int iMaxIndex)
        {
            int iEnd = fnGetEndIndex(iMaxIndex);

            List<int> lRight = fnGetListByArrayStartAndEnd(iMaxIndex + 1, iEnd);

            if (lRight.Count > 0)
            {
                int iMax = lRight.Max();
                iMaxIndex = Array.IndexOf(aSign, iMax);

                TreeNode TNRight = new TreeNode();
                TNRight.val = iMax;
                aSign[iMaxIndex] = -1;
                TNRight.left = fnGetLeftNode(TNNode, iMaxIndex);
                TNRight.right = fnGetRightNode(TNNode, iMaxIndex);

                return TNRight;
            }

            return null;
        }
        #endregion

        #region -- fnGetListByArrayStartAndEnd --
        private List<int> fnGetListByArrayStartAndEnd(int iStart, int iEnd)
        {
            List<int> lNums = new List<int>();

            for (int iCount = 0; iStart >= 0 && iEnd <= aSign.Length - 1 && iCount <= (iEnd - iStart); iCount++)
            {
                if (aSign[iCount + iStart] != -1)
                {
                    lNums.Add(aSign[iCount + iStart]);
                }
            }

            return lNums;
        }
        #endregion

        #region -- fnGetStartIndex --
        private int fnGetStartIndex(int iIndex)
        {
            int iStart = iIndex - 1;

            while (iStart > 0 && aSign[iStart] != -1)
            {
                iStart--;
            }

            return iStart;
        }
        #endregion

        #region -- fnGetEndIndex --
        private int fnGetEndIndex(int iIndex)
        {
            int iStart = iIndex + 1;

            while (iStart < aSign.Length - 1 && aSign[iStart] != -1)
            {
                iStart++;
            }

            return iStart;
        }
        #endregion

        #region -- TreeNode --
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        #endregion
    }
}

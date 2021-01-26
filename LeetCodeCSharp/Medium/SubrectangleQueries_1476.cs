using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Medium
{
    public class SubrectangleQueries_1476
    {
        private int[][] aaTable;

        public SubrectangleQueries_1476(int[][] rectangle)
        {
            aaTable = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int iRow = row1; iRow <= row2; iRow++)
            {
                for (int iCol = col1; iCol <= col2; iCol++)
                {
                    aaTable[iRow][iCol] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return aaTable[row][col];
        }
    }
}

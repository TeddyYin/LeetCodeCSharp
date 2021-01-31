using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Medium
{
    class LargestValuesFromLabels_1090
    {
        public int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            int iAns = 0;

            Array.Sort(values, labels);

            Dictionary<int, int> dCountTimes = new Dictionary<int, int>();
            //List<int> lValue = values.ToList();
            //lValue.Sort();

            for (int iCount = values.Length - 1; 0 <= iCount && num_wanted > 0; iCount--)
            {
                //int iIndex = Array.IndexOf(values, values[iCount]);

                if (dCountTimes.ContainsKey(labels[iCount]))
                {
                    if (dCountTimes[labels[iCount]] < use_limit)
                    {
                        iAns += values[iCount];
                        dCountTimes[labels[iCount]]++;
                        num_wanted--;
                    }
                }
                else
                {
                    iAns += values[iCount];
                    dCountTimes.Add(labels[iCount], 1);
                    num_wanted--;
                }

                values[iCount] = -1;
            }

            return iAns;
        }
    }
}

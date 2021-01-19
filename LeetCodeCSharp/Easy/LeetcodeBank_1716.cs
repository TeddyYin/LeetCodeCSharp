using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    class LeetcodeBank_1716
    {
        public int TotalMoney(int n)
        {
            int iAns = 0;

            int iDivisor = n / 7;
            int iRemainder = n % 7;

            for (int i = 0; i < iDivisor; i++)
            {
                iAns += 28 + 7 * i;
            }

            for (int i = 1, iMondayMoney = iDivisor + 1; i <= iRemainder; i++, iMondayMoney++)
            {
                iAns += iMondayMoney;
            }

            return iAns;
        }
    }
}

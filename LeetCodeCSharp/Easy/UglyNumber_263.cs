using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Easy
{
    class UglyNumber_263
    {
        public bool IsUgly(int num)
        {
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else if (num % 3 == 0)
                {
                    num /= 3;
                }
                else if (num % 5 == 0)
                {
                    num /= 5;
                }
                else
                {
                    break;
                }
            }

            return num == 1;
        }
    }
}

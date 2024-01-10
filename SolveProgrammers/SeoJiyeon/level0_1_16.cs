using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{   // 피자 나눠 먹기 (1)
    internal class level0_1_16
    {
        public int solution(int n)
        {
            int answer = 0;
            if (n % 7 == 0)
            {
                answer = n / 7;
            }
            else
            {
                answer = n / 7 + 1;
            }
            return answer;
        }
    }
}

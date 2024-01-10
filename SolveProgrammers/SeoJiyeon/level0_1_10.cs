using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{   // 짝수의 합 구하기
    internal class level0_1_10
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}

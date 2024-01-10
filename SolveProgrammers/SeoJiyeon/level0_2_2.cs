using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{
    internal class level0_2_2
    {   // 배열 두배 만들기
        public int[] solution(int[] numbers)
        {

            int[] answer = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i] * 2;

            }
            return answer;
        }
    }
}

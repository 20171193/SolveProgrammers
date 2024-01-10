using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{   // 배열 자르기
    internal class level0_1_19
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int[] answer = new int[num2];
            for (int i = 0; i < num2; i++)
            {
                answer[i] = numbers[num1];
                num1++;
            }
            return answer;
        }
    }
}

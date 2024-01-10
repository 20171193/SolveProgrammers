using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{
    internal class level0_1_19
        // 배열 자르기
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int[] answer = new int[num2 - num1 + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = numbers[i + num1];
            }
            return answer;
        }
    }
}

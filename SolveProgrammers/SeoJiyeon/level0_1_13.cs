using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.SeoJiyeon
{
    internal class level0_1_13
    {   // 배열 뒤집기
        public int[] solution(int[] num_list)
        {
            Array.Reverse(num_list); //먼저 뒤집기
            int[] answer = num_list; // answer 배열 값 지정하기
            return answer; // answer 출력하기
        }
    }
}

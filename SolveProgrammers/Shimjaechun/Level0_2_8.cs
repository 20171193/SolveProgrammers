using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Shimjaechun
{
    internal class Level0_2_8
    {
        public int solution(int[] array)
        {
            int answer = 0;
            Array.Sort(array);
            int middlePos = array.Length / 2;
            answer = array[middlePos];
            return answer;
        }
    }
}

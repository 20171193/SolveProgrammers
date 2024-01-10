using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Shimjaechun
{
    internal class Level0_4_1
    {
        public int solution(string my_string, string is_suffix)
        {
            int answer = 0;

            for (int i = 0; i < my_string.Length; i++)
            {
                if (is_suffix == my_string.Substring(i, my_string.Length - i)) return 1;
            }

            return answer;
        }
    }
}

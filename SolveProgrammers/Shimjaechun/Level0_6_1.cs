using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Shimjaechun
{
    internal class Level0_6_1
    {
        public string solution(string n_str)
        {
            string answer = "";
            int cnt = 0;
            if (n_str[0] == '0')
            {
                cnt++;
                for (int i = 1; i < n_str.Length; i++)
                {
                    if (n_str[i] == '0') cnt++;
                    else break;
                }
            }
            answer = n_str.Substring(cnt, n_str.Length - cnt);
            return answer;
        }
    }
}

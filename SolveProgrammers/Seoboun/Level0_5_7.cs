using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Seoboun
{
    class Level0_5_7
    {
        public int solution(int a, int b)
        {
            // 유한소수 판별하기
            int answer = 0;

            int max = a > b ? a : b;
            int min = a < b ? a : b;
            int g = 1;

            // 판별을 위해 분자와 분모의 최대 공약수를 찾고
            while (true)
            {
                g = max % min;
                max = min;
                if (g == 0)
                {
                    g = min;
                    break;
                }
                min = g;
            }

            b = b / g;
            if (b == 1)
            {
                answer = 1;
                return answer;
            }

            // 분모를 최대 공약수로 나눠 소인수 분해를 함
            int i = 2;
            int[] prime = new int[100];
            int count = 0;
            while (i <= b)
            {
                if (b % i == 0)
                {
                    b = b / i;
                    prime[count] = i;
                    i = 1;
                    count++;
                }
                i++;
            }
            answer = 1;

            // 그리고 분모의 소인수가 2 혹은 5 이외에 다른 수가 있다면 소인수 분해 불가능
            i = 0;
            while (prime[i] != 0)
            {
                if (prime[i] != 2 && prime[i] != 5)
                {
                    answer = 2;
                    break;
                }
                i++;
            }

            return answer;
        }
    }
}

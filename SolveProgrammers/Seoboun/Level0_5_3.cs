using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Seoboun
{
    class Level0_5_3
    {
        public int solution(int[,] dots)
        {
            // 사각형 넓이 구하기
            // 사각형? -> x * y
            // 변의 길이 => 가장 큰 값 - 가장 작은 값 
            // 조건에 -256 ~ 256이므로 max, min 설정
            int answer = 0;
            int maxX = -256;
            int maxY = -256;
            int minX = 256;
            int minY = 256;

            for (int i = 0; i < 4; i++)
            {
                if (maxX < dots[i, 0])
                    maxX = dots[i, 0];
                if (minX > dots[i, 0])
                    minX = dots[i, 0];
                if (maxY < dots[i, 1])
                    maxY = dots[i, 1];
                if (minY > dots[i, 1])
                    minY = dots[i, 1];
            }
            answer = (maxX - minX) * (maxY - minY);

            return answer;
        }
    }
}

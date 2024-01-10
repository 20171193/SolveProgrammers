using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Seoboun
{
    class Level0_5_5
    {
        public int[] solution(int[,] score)
        {
            int[] answer = new int[score.GetLength(0)];
            float[] mean = new float[score.GetLength(0)];
            int rank;

            // 평균 계산
            for (int i = 0; i < score.GetLength(0); i++)
            {
                mean[i] = (score[i, 0] + score[i, 1]) / 2.0f;
            }

            for (int i = 0; i < mean.Length; i++)
            {
                // 랭크 계산
                rank = 1;
                for (int j = 0; j < mean.Length; j++)
                {
                    // 만약 현재 점수보다 높은 사람이 있다면
                    // 등수 하나 밀리기
                    if (mean[i] < mean[j])
                    {
                        rank++;
                    }
                }
                answer[i] = rank;
            }

            return answer;
        }
    }
}

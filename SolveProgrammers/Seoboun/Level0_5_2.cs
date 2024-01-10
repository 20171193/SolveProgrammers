using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Seoboun
{
    class Level0_5_2
    {
        public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[2];
            string input = "";
            // 보드의 경계선 설정
            int leftBoundary = -(board[0] / 2);
            int rightBoundary = (board[0] / 2);
            int upBoundary = (board[1] / 2);
            int downBoundary = -(board[1] / 2);

            for (int i = 0; i < keyinput.Length; i++)
            {
                input = keyinput[i];

                // 입력에 따라 경계선을 체크하며 이동
                switch (input)
                {
                    case "left":
                        answer[0]--;
                        if (answer[0] < leftBoundary)
                            answer[0] = leftBoundary;
                        break;
                    case "right":
                        answer[0]++;
                        if (answer[0] > rightBoundary)
                            answer[0] = rightBoundary;
                        break;
                    case "up":
                        answer[1]++;
                        if (answer[1] > upBoundary)
                            answer[1] = upBoundary;
                        break;
                    case "down":
                        answer[1]--;
                        if (answer[1] < downBoundary)
                            answer[1] = downBoundary;
                        break;
                }
            }

            return answer;
        }
    }
}

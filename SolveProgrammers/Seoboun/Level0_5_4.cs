using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.Seoboun
{
    class Level0_5_4
    {
        public string solution(string[] id_pw, string[,] db)
        {
            string answer = "";

            answer = "fail";
            for (int i = 0; i < db.GetLength(0); i++)
            {
                // id가 같은 상황에서
                if (id_pw[0] == db[i, 0])
                {
                    // pw도 동일하다면
                    if (id_pw[1] == db[i, 1])
                    {
                        // 로그인 성공
                        answer = "login";
                    }
                    // pw가 일치하지 않다면
                    if (answer != "login")
                    {
                        // id는 일치하나 pw는 틀린 상황
                        answer = "wrong pw";
                    }
                }
            }

            return answer;
        }
    }
}

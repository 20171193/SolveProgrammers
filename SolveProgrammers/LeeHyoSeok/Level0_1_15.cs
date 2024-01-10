using System;

public class Class1
{
        // 양꼬치

        public class Solution
    {
        public int solution(int n, int k)
        {
            k = k - n / 10;

            n = n * 12000;
            k = k * 2000;

            int answer = n + k;
            return answer;
        }
    }
}


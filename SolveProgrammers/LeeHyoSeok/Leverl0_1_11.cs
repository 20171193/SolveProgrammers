using System;

public class Class3
{

        // 배열의 평균값

        public class Solution
    {
        public double solution(int[] numbers)
        {
            int allNum = numbers.Length;
            double total = 0;
            for (int i = 0; i < allNum; i++)
            {
                total += numbers[i];
            }
            total /= allNum;
            return total;
        }
    }
}


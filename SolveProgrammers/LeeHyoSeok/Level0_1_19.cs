using System;

public class Class1
{
    public Class1()
    {  
        // 배열 자르기

        public class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            for (int i = 0; i< numbers.Length; i++)
            {
                if(num1<= i && num2 >= i)
                {
                    int[] aaa = new int[] { numbers[i] };
                    return aaa;
                }
            }

            
            return aaa;
        }
    }
}
}

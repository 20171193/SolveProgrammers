namespace SolveProgrammers.Seoboun
{
    class Level0_5_6
    {
        public int solution(int chicken)
        {
            int answer = 0;
            int coupon = 0;

            // 한마리씩 체크
            for (int i = 1; i <= chicken; i++)
            {
                // 만약 10마리 주문했으면
                if (i % 10 == 0)
                {
                    // 쿠폰 하나 증가
                    coupon++;
                    // 치킨수도 증가
                    chicken++;
                }
            }

            answer = coupon;

            return answer;
        }
    }
}

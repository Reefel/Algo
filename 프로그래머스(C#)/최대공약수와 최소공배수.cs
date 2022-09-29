public class Solution {
    public int[] solution(int n, int m) {
        int d = 0;
        int[] answer = new int[2];
        
        //m의 값이 더크면 n과 m의 값을 바꿔줌
        if (m > n)
        {
            d = n;
            n = m;
            m = d;
        }
        
        for (int i = 1; i <= n; i++)
        {
            d = n * i;
            for (int j = 1; j <= n ; j++)
            {
                if(d == m * j)
                {
                    answer[1] = d;
                    break;
                }
            }
            if (answer[1] != 0) break;
        }
        while(true)
        {
            d = n % m;
            if (d == 0)
            {
                answer[0] = m;
                break;
            }
            else
            {
                n = m;
                m = d;
            }
        }
        return answer;
    }
}

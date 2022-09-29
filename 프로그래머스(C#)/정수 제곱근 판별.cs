using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        for(int i=1; i<=n; i++)
            {
                if(Math.Pow(i , 2) == n)
                {
                    answer = (long)Math.Pow(i + 1, 2);
                    break;
                }
                answer = -1;
            }
            return answer;
    }
}

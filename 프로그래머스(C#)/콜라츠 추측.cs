using System;

public class Solution {
    public int solution(int num) {
        int answer = 0;
        long number = num;
        while (answer < 500 && number != 1 )
        {
            answer++;
            if (number % 2 == 0 || number == 0 )
            {
                number /= 2;
                continue;
            }
            if (number == 1) break;
            if (number % 2 == 1 )
            {
                number = number * 3 + 1;
                continue;
            }
        }
        if (answer == 500) answer = -1;
        return answer;
    }
}

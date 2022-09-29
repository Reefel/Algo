using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int sum = 0;
        int answer = 0;
        Array.Sort(d);
        for (int i = 0; i < d.Length; i++)
        {
            sum += d[i];
            if (sum > budget) break;
            answer++;
        }
        return answer;
    }
}

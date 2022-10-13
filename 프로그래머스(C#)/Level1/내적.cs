using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        //a.zip 사용해서 풀 수 있음
        int answer = 0;
        for (int i = 0; i <= a.Length - 1; i++)
        {
            answer += a[i] * b[i];
        }
        return answer;
    }
}

using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int length = n.ToString().Length;
            for(int i=0; i<length; i++)
            {
                answer += int.Parse(n.ToString().Substring(i,1));
            }   
        return answer;
    }
}

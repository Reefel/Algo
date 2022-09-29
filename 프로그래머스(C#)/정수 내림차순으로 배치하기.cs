using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        int size = n.ToString().Length;
        long[] result = new long[size];
        string sValue = string.Empty;
        
        for (int i = 0; i < n.ToString().Length; i++)
        {
            result[i] = int.Parse(n.ToString().Substring(i, 1));
        }
        
        Array.Sort(result);
        Array.Reverse(result);
        
        for (int i = 0; i < n.ToString().Length; i++)
        {
            sValue += result[i].ToString();
        }
        answer = long.Parse(sValue);
        return answer;
    }
}

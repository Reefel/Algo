using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int i = 0;
        int[] value = new int[s.Length];
        
        foreach (var item in s)
        {                 
            value[i] = (int)item;
            i++;
        }
        Array.Sort(value);
        Array.Reverse(value);

        for (int j = 0; j < value.Length; j++)
        {
            answer += Convert.ToChar(value[j]);
        }
        
        return answer;
        
    }
}

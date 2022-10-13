using System;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[1];
        Array.Sort(strings);
        
        for (int i = 0; i < strings.Length - 1; i++)
        {
            if ((int)char.Parse(strings[i].Substring(n, 1)) == (int)char.Parse(strings[i+1].Substring(n, 1))) continue;
            if ((int)char.Parse(strings[i].Substring(n, 1)) > (int)char.Parse(strings[i+1].Substring(n, 1)))
            {
                answer[0] = strings[i];
                strings[i] = strings[i + 1];
                strings[i + 1] = answer[0];
                i = -1;
            }
        }
        return strings;
    }
}

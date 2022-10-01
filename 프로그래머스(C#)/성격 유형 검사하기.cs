using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string[] str = new string[] { "RT", "CF", "JM", "AN" };
        int[] count = new int[4];
        string str_reverse = "";
        string answer = "";
        
        for (int i = 0; i < survey.Length; i++)
        {
            if(Array.IndexOf(str, survey[i]) != -1)
            {
                count[Array.IndexOf(str, survey[i])] += choices[i] - 4;
                continue;
            }
            str_reverse = survey[i].Substring(1, 1) + survey[i].Substring(0, 1);
            if(Array.IndexOf(str, str_reverse) != -1)
            {
                count[Array.IndexOf(str, str_reverse)] += choices[i] * -1 + 4;
                continue;
            }
        }
        
        for (int i = 0; i < str.Length; i++)
        {
            if (count[i] > 0) answer += str[i].Substring(1, 1);
            if (count[i] < 0) answer += str[i].Substring(0, 1);
            if (count[i] == 0)
            {
                string[] list = new string[] { str[i].Substring(0, 1), str[i].Substring(1, 1) };
                Array.Sort(list);
                answer += list[0];
            };
        }
        return answer;
    }
}

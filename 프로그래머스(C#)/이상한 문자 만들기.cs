public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] result = s.Split(new char[] { ' ' });
        
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result[i].Length; j++)
            {
                answer += j % 2 == 0 ? result[i].Substring(j, 1).ToUpper() : result[i].Substring(j, 1).ToLower();
            }
            if (i != result.Length - 1) answer += " ";
        }
        return answer;
    }
}

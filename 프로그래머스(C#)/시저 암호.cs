public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int number = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s.Substring(i, 1) == " ")
            {
                answer += " ";
                continue;
            }
            number = (int)char.Parse(s.Substring(i, 1));
            if (number <= 90 && number + n > 90)
            {
                number = (number + n) - 90;
                number += 64;
                answer += (char)number;
                continue;
            }
            if (number <= 122 && number + n > 122)
            {
                number = (number + n) - 122;
                number += 96;
                answer += (char)number;
                continue;
            }
            else
            {
                number = number + n;
                answer += (char)number;
            }
        }
        return answer;
    }
}

public class Solution {
    public string solution(string s) {
        string answer = "";
        int length = s.Length;
        
        answer += length % 2 == 1 ? s.Substring(((length + 1) / 2) - 1 , 1)  : s.Substring((length / 2) - 1 , 2);
        
        return answer;
    }
}

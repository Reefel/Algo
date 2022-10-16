public class Solution {
    public bool solution(string s) {
        bool answer = true;
        //s.TryParse() 사용해서 문제 해결 가능 <= 숫자인지 체크해줌
        
        foreach (var item in s)
        {
            if ((int)item > 57 || s.Length != 4 && s.Length != 6) answer = false;
        }
        return answer;
    }
}

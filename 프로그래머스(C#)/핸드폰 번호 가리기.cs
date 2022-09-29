using System;
using System.Text;

public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int length = phone_number.Length;
        StringBuilder sb = new StringBuilder(phone_number);

        for (int i = length - 5; i >= 0; i--)
        {
            sb[i] = '*';
        }
        answer = sb.ToString();
        return answer;
    }
}

using System;
using System.Globalization;


public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        DateTime dateValue = new DateTime(2016, a, b);
        answer = dateValue.ToString("ddd", new CultureInfo("en")).ToUpper();
        return answer;
    }
}

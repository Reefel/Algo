using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] int_result = Array.ConvertAll(s.Split(" "), a => int.Parse(a));
        answer = int_result.Min() + " " + int_result.Max();
        return answer;
    }
}

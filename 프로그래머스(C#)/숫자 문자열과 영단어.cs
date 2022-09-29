using System;

public class Solution {
    public int solution(string s) {
        //Replace 쓰면 간단하게 풀 수 있음
        int[] number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] Snumber = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string sub = "";
        string a = "";
        int count = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < number.Length; j++)
            {
                if (number[j].ToString() == s.Substring(i, 1))
                {
                    a += s.Substring(i, 1);
                    count++;
                    break;
                }
            }
            if(count != 0)
            {
                count--;
                continue;
            }
            sub += s.Substring(i, 1);
            if (Array.IndexOf(Snumber, sub) == -1) continue;
            a += number[Array.IndexOf(Snumber, sub)];
            sub = "";
        }
        return int.Parse(a);
    }
}

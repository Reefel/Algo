using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int[] X_value = new int[10];
        int[] Y_value = new int[10];
        
        for (int i = 0; i < X.Length; i++) X_value[int.Parse(X[i].ToString())]++;
        for (int i = 0; i < Y.Length; i++) Y_value[int.Parse(Y[i].ToString())]++;
        for (int i = 9; i >= 0; i--)
        {
            if (X_value[i] == 0) continue;
            if (Y_value[i] == 0) continue;
            int a = Math.Min(X_value[i], Y_value[i]);
            answer += string.Concat(Enumerable.Repeat(i, a));
        }
        
        if (answer.Length <= 0) answer = "-1";
        if (answer.Substring(0, 1) == "0") answer = "0";
        
        return answer;
    }
}

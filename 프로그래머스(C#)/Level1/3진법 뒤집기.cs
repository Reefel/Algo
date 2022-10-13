using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();
        int[] result = new int[] { };
        int answer = 0;
        
        while (n > 0)
        {
            list.Add((n % 3));
            n = n / 3;
        }
        
        result = list.ToArray();
        Array.Reverse(result);

        for (int i = 0; i < result.Count(); i++)
        {
            int je = ((int)Math.Pow(3, i)) ;
            answer += je * result[i];
        }
        return answer;
    }
}

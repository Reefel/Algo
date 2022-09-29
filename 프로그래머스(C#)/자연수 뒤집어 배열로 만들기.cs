using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        
        for(int i=n.ToString().Length-1;i>=0;i--)
            {
                list.Add(int.Parse(n.ToString().Substring(i, 1)));
            }
        
        answer = list.ToArray();
        return answer;
    }
}

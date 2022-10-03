using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        List<int> list = new List<int>();
        int answer = 0;
        
        Array.Sort(reserve);
        Array.Sort(lost);
        
        for (int i = 0; i < reserve.Length; i++)
        {
            if (Array.IndexOf(lost, reserve[i]) == -1)
            {
                list.Add(reserve[i]);
                continue;
            }
            lost = lost.Where(x => x != lost[Array.IndexOf(lost, reserve[i])]).ToArray();
        }
        
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < lost.Length; j++)
            {
                if (Array.IndexOf(lost, list[i] - 1) != -1)
                {
                    lost = lost.Where(x => x != lost[Array.IndexOf(lost, list[i] - 1)]).ToArray();
                    break;
                }
                if (Array.IndexOf(lost, list[i] + 1) != -1)
                {
                    lost = lost.Where(x => x != lost[Array.IndexOf(lost, list[i] + 1)]).ToArray();
                    break;
                }
            }
        }
        answer = n - lost.Length;
        return answer;
    }
}

using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        
        // 굳이 리스트를 만들어서 안넣어도됨 그냥 Count만 ++ 해주면 그만
        int answer = 0;
        List<int> list = new List<int>();
        
        for (int i = left; i <= right ; i++)
            {
                list.Clear();
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) list.Add(j);
                }
                if(list.Count % 2 == 0)
                {
                    answer += i;
                    continue;
                }
                answer -= i;
            }
        return answer;
    }
}

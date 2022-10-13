using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int[] result = new int[] { 6, 3, 1, -1, -3, -5 };
        int count = lottos.Where(x => x == 0).Count();
        
        Array.Sort(lottos);
        Array.Sort(win_nums);
        
        var list = win_nums.Intersect(lottos);
        
        answer[0] = list.Count() + count == 0 ? 6 : list.Count() + count + result[list.Count() + count - 1];
        answer[0] = answer[0] > 6 ? answer[0] - 1 : answer[0];
        answer[1] = list.Count() + result[list.Count() <= 1 ? 0 : list.Count() - 1];
        answer[1] = answer[1] > 6 ? answer[1] - 1 : answer[1]; 
        
        return answer;
    }
}

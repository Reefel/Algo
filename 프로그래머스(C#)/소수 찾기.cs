using System.Linq;

public class Solution {
    public int solution(int n) {
        int result = 0;
        int[] answer = new int[n + 1];
        
        for (int i = 2; i <= n; i++)
        {
            answer[i] = i;
        }
        
        for (int i = 2; i <= n; i++)
        {
            if (answer[i] == 0) continue;
            for (int j = i + i; j <= n; j += i)
            {
                answer[j] = 0;
            }
        }
        result = answer.Where(a => a != 0).ToArray().Length;
        return result;
    }
}

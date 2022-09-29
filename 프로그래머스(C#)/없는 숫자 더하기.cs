using System;

public class Solution {
    public int solution(int[] numbers) {
        //차집합 써도됨
        int answer = 0;
        
        Array.Sort(numbers);
        for (int i = 0; i <= 9; i++)
        {
            if(!Array.Exists(numbers, x => x == i)) answer += i;
        }
        
        return answer;
    }
}

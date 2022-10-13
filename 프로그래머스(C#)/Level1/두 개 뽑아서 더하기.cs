using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[]{};
        List<int> list = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j <= numbers.Length - 1; j++)
            {
                if (Array.IndexOf(list.ToArray(), numbers[i] + numbers[j]) != -1) continue;
                list.Add(numbers[i] + numbers[j]);
                continue;
            }
        }
        answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}

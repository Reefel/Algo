using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int length = arr.Length;
        int[] answer;
        List<int> list = new List<int>();

        for (int i = 0; i < length; i++)
        {
            if (arr[i] % divisor == 0) list.Add(arr[i]);
        }
        if (list.Count == 0) list.Add(-1);
        answer = new int[list.Count()];
        answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}

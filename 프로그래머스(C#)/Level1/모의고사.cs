using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer;
        int[,] user123 = new int[,] { { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 }, { 2, 1, 2, 3, 2, 4, 2, 5, 0, 0 }, { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 } };
        int count = 0;
        int[] userresult = new int[3];
        List<int> list = new List<int>();
        int row = 0;
        
        for (int i = 0; i <= 2; i++)
        {
            count = 0;
            row = 0;
            for (int j = 0; count < answers.Length; j++)
            {
                if (user123[i, row] == 0)
                {
                    row = 0;
                    j--;
                    continue;
                }
                if (answers[j] == user123[i, row]) userresult[i]++;
                if (row == user123.GetLength(1) - 1)
                    row = -1;
                count++;
                row++;
            }
        }
        
        for (int i = 0; i < userresult.Length; i++)
        {
            if (userresult.Max() != 0 && userresult[i] == userresult.Max()) list.Add(i + 1);
        }
        answer = new int[list.Count];
        answer = list.ToArray();
        return answer;
    }
}

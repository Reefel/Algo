using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer;
        int[] a = new int[commands.Length / 3];
        int start = 0;
        int end = 0;
        int length = 0;
        
        for (int i = 0; i < (commands.Length) / 3; i++)
        {
            start = commands[i,0] - 1;
            end = commands[i, 1] - 1;
            length = end - start + 1 < 0 ? (end - start + 1) * -1 : end - start + 1;
            answer = new int[length];
            Array.Copy(array, start, answer, 0, length);
            Array.Sort(answer);
            a[i] = answer[commands[i, 2] - 1];
        }
        return a;
    }
}

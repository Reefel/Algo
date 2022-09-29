using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int   length = arr.Length;
        int[] answer = new int[length];
        int   min    = arr.Min();
        
        answer = arr.Where(val => val != min).ToArray();   
        
        if(answer.Length <= 1) return new int[] {-1};
        return answer;
    }
}

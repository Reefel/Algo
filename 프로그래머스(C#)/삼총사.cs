using System;
using System.Collections.Generic;

public class Solution {
    int b = 0;

    public int solution(int[] number) {
        int answer = 0;
        int index = 0;
        List<int> num = new List<int>();
        return Returnmethod(num, number, index);
    }
    
    public int Returnmethod(List<int> num, int[] nums, int a)
    {
        if (num.Count == 3)
        {
            int Sum_List = num[0] + num[1] + num[2];
            if (Sum_List != 0) return 0;
            return b += 1;
        }
        if(a >= nums.Length) return 0;
        num.Add(nums[a]);
        Returnmethod(num, nums, a + 1);
        num.RemoveAt(num.Count - 1);
        Returnmethod(num, nums, a + 1);
        return b;
    }
}

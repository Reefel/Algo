public class Solution {
    public bool solution(int x) {
        int sum = 0;
        for(int i=0; i < x.ToString().Length; i++)
            {
                sum += int.Parse(x.ToString().Substring(i, 1));
            }
        return x % sum == 0 ? true : false;
    }
}

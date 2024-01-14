public class Solution {
    public long solution(long n) {
        long answer = -1;
        long x = 1;
        while(x * x <= n)
        {
            if(x * x == n)
            {
                x++;
                answer = x * x;
                break;
            }
            x++;
        }
        return answer;
    }
}
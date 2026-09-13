class Solution {
    public long solution(long n) {
        long answer = -1;
        long x = 1;
        while(x * x <= n)
        {
            x += 1;
        }
        answer = (x-1) * (x-1) == n ? x * x : answer;
        return answer;
    }
}
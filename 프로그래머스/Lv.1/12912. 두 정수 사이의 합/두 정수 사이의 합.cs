public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int x = a < b ? a : b;
        int y = a < b ? b : a;
        for(int i = x ; x <= y; x++)
        {
            answer = answer + x;
        }
        return answer;
    }
}
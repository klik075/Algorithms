using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        if(a % 2 != 0 && b % 2 != 0)
        {
            answer = a * a + b * b;
        }
        else if(a % 2 != 0 || b % 2 != 0)
        {
            answer = 2 * (a + b);
        }
        else
        {
            answer = a > b ? a - b : b - a;
        }
        return answer;
    }
}
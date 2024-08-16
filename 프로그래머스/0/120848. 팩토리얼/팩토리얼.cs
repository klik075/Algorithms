using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int i = 1;
        while(factorial(i) <= n)
        {
            i++;
        }
        answer = i -1;
        
        return answer;
    }
    public int factorial(int num)
        {
            if(num != 1)
                return num * factorial(num - 1);
            else
                return 1;
        }
}
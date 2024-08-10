using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        int i = 1;
        while(i * i <= n)
        {
            if(i * i == n)
            {
                answer = 1;
                break;
            }
            
            i++;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 1;
    
        for(int i = 1; i < dots.GetLength(0); i++)
        {
            int x = Math.Abs(dots[i,0] - dots[0,0]);
            int y = Math.Abs(dots[i,1] - dots[0,1]);
            if(x != 0 && y != 0)
                continue;
            if(x == 0)
                answer *= y;
            else
                answer *= x;
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        int count = 0;
        bool reverse = false;
        int startX =0;
        int startY =0;
        int maxX = n;
        int maxy = n;
        int minX =0;
        int minY =0;
        while(count < n * n)
        {
            if(reverse == false)
            {
                for(int i = startX ; i < maxX; i++)
                {
                    answer[startY,i] = ++count;
                    startX = i;
                }
                 for(int j = startY + 1 ; j < maxy; j++)
                {
                    answer[j,startX] = ++count;
                    startY = j;
                }
                maxX--;
                maxy--;
            }
            else
            {
                for(int i = startX - 1 ; i >= minX; i--)
                {
                    answer[startY,i] = ++count;
                    startX = i;
                }
                for(int j = startY - 1 ; j > minY; j--)
                {
                    answer[j,startX] = ++count;
                    startY = j;
                }
                minX++;
                minY++;
                startX++;
            }
            reverse = !reverse;
        }
        return answer;
    }
}
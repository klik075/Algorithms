using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int min = 0;
        int max = 0;
        int width = 0;
        int large = 0;
        int small = 0;
        for(int i = 0;i< sizes.GetLength(0);i++)
        {
            large = sizes[i,0] > sizes[i,1] ? sizes[i,0] : sizes[i,1];
            small = sizes[i,0] > sizes[i,1] ? sizes[i,1] : sizes[i,0];
            if(max <= large && min <= small)
            {
                max = large;
                min = small;
            }

            if(max < large)
            {
                max = large;
            }
            if(min < small)
            {
                min = small;
            }
            width = max * min;
            
        }
        answer = width;
        return answer;
    }
}
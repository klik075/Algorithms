using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for(int i = 0; i< number.Length-2 ;i++)
        {
            for(int j = i+1; j< number.Length-1;j++)
            {
                for(int r = j+1;r<number.Length;r++)
                {
                    if(number[i]+number[j]+number[r] == 0)
                        answer += 1; 
                }
            }
        }
        return answer;
    }
}
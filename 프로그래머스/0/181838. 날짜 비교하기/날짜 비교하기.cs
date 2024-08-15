using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        int answer = 1;
        int result = 0;
        for(int i = 0; i < date1.Length; i++)
        {
            result += date2[i] - date1[i];
            if(result < 0)
            {
                answer = 0;
                break;
            }
            else if(result > 0)
            {
                answer = 1;
                break;
            }
        }
        if(result == 0)
            answer = 0;
        return answer;
    }
}
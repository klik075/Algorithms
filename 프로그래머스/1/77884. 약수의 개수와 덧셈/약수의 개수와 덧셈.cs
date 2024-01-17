using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int result =0;
        int x =0;
        for(int i = left;i<right+1;i++)
        {
            result =0;
            x=1;
            for(int j = x;x<right+1;x++)
            {
                if(i%x == 0)
                    result++;
            }
            if(result % 2 == 0)
                answer += i;
            else if(result % 2 == 1)
                answer -= i;
        }
        return answer;
    }
}
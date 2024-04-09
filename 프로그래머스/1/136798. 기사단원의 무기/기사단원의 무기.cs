using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int num = 2;
        int max = 0;
        for(int i = 1; i < number + 1; i++)
        {   
            num = 2;
            max = i/2;
            for(int j = 2 ; j <= max;j++)
            {
                if(i % j == 0)
                {
                    ++num;
                }
                if(num > limit)
                    break;
            }
            if(num > limit)
            {
                answer += power;
            }
            else
            {
                answer += num;
            }    
        }
        answer--;
        
        return answer;
    }
}
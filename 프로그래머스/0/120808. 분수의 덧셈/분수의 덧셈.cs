using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        answer[0] = numer1 * denom2 + numer2 * denom1;
        answer[1] = denom1 * denom2;
        int min;
        int temp;
        while(true)
        {
            min = Math.Min(answer[0], answer[1]);
            temp = answer[0];
            
            for(int i = 2; i <= min; i++)
            {
                if(answer[0] % i == 0 && answer[1] % i == 0)
                {
                    answer[0] /= i;
                    answer[1] /= i;
                    break;
                }
            }
            
            if(temp == answer[0])
                break;
        }
        
        return answer;
    }
}
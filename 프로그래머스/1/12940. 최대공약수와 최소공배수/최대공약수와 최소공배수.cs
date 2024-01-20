public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int max = 0;
        int min = 0;
        int minValue=0;
        int maxValue =0;
        if(n <= m)
        {
            max = m;
            min = n;
        }
        else
        {
            max = n;
            min = m;
        }
        minValue = min;
        maxValue = max;
            
        for(int i = 1; i < max +1 ; i++)
        {
            if(i <= min && n % i == 0 && m % i == 0)
            {   
                answer[0] = i;
            }
        }
        
        while(true)
        {
            if(max == min)
                break;
            if(max > min)
            {
                min += minValue;
                continue;
            }   
            if(max < min)
            {
                max += maxValue;
                continue;
            }

        }
        answer[1] = min;
        
        return answer;
    }
}
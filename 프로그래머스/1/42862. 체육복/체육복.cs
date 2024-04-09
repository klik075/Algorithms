using System;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        int[] student = new int[n+2];
        for(int i = 0; i < lost.Length; i++)
        {
            student[lost[i]] -= 1;
        }
        for(int i = 0 ; i < reserve.Length; i++)
        {
            student[reserve[i]] += 1;
            
        }
        for(int i = 1; i < n+2; i++)
        {
            if(student[i] == -1)
            {
                if(student[i-1] == 1 ) 
                {
                    student[i-1] -= 1;
                    student[i] += 1;
                    continue;
                }
                if(student[i+1] == 1 )
                {
                    student[i+1] -=1;
                    student[i] += 1;
                    continue;
                }
                answer -= 1;
            }
        }
        return answer;
    }
}
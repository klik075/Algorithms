using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        for(int m = i; m <= j;m++)
        {
            int temp = m;
            do{
                if(temp % 10 == k)
                    answer++;
                
                temp = temp/10;
            }while(temp != 0);
        }
        return answer;
    }
}
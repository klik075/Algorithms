using System;

public class Solution {
    public int solution(int[] arr) {
        int length = arr.Length;
        int[] temp = new int[length];
        int answer = 0;
        
        while(true)
        {
            int count = length;
            answer++;
            for(int i = 0 ; i < length; i++)
            {
                if(arr[i] > 50 && arr[i] % 2 == 0)
                {
                    temp[i] = arr[i] / 2;
                }
                else if(arr[i] < 50 && arr[i] % 2 != 0)
                {
                    temp[i] = (arr[i] * 2) + 1;
                }
                else
                {
                    temp[i] = arr[i];
                }                   
            }
            for(int i = 0 ; i < length; i++)
            {
                if(temp[i] == arr[i])
                    count--;
                
                arr[i] = temp[i];
            }
            
            if(count == 0)
            {
                answer--;
                break;
            }
        }
        return answer;
    }
}
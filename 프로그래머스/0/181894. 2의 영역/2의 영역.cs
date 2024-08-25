using System;

public class Solution {
    public int[] solution(int[] arr) {
        int start = -1;
        int end = arr.Length;
        for(int i = 0 ; i < arr.Length;i++)
        {
            if(arr[i] == 2 && start == -1)
            {
                start = i;
                end = i;
            }
            else if(arr[i] == 2)
                end = i;
        }
        int[] answer;
        if(start == -1)
        {
            answer = new int[1]{-1};
        }
        else
        {
            answer = new int[end - start + 1];
            Array.Copy(arr,start,answer,0,end - start + 1);
        }
            
        
        return answer;
    }
}
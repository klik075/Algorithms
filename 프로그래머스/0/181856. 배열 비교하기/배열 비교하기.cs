using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        int result1 = 0;
        int result2 = 0;
        if(arr1.Length < arr2.Length)
        {
            answer = -1;
        }
        else if(arr1.Length > arr2.Length)
        {
            answer = 1;
        }
        else
        {
            for(int i = 0 ; i < arr1.Length;i++)
            {
                result1 += arr1[i];
                result2 += arr2[i];
            }
            if(result1 > result2)
            {
                answer = 1;
            }
            else if(result1 < result2)
            {
                answer = -1;
            }
            else
            {
                answer = 0;
            }
        }
        return answer;
    }
}
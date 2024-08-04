using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        for(int i = 0 ;i<arr.Length;i++)
        {
            if(arr.Length % 2 == 0)
            {
                if(i % 2 == 0)
                    answer[i] = arr[i];
                else
                    answer[i] = arr[i] + n;
            }
            else
            {
                if(i % 2 == 0)
                    answer[i] = arr[i] + n;
                else
                    answer[i] = arr[i];
            }
        }
        return answer;
    }
}
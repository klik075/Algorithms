using System;

public class Solution {
    public int[] solution(int[] arr) {
        int length = arr.Length;
        int two = 1;
        while(true)
        {
            if(length <= two)
            {
                break;
            }
            two *= 2;
        }
        int[] answer = new int[two];
        for(int i = 0; i < answer.Length; i++)
        {
            if(i < arr.Length)
                answer[i] = arr[i];
            else
                answer[i] = 0;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int max = -1;
        for(int i = 0 ; i < array.Length;i++)
        {
            if(max <= array[i])
            {
                max = array[i];
                answer[0] = array[i];
                answer[1] = i;
            }
        }
        return answer;
    }
}
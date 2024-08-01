using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];
        Array.Sort(num_list);
        for(int i = 0 ; i < answer.Length; i++)
        {
            answer[i] = num_list[i];
        }
        return answer;
    }
}
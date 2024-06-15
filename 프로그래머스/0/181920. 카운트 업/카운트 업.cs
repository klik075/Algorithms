using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int[] answer = new int[end_num - start_num + 1];
        int num = start_num;
        for(int i = 0 ; i < answer.Length ; i++)
        {
            answer[i] = num;
            num++;
        }
        return answer;
    }
}
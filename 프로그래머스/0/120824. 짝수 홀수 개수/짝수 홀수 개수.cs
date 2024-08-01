using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        foreach(var num in num_list)
        {
            if(num % 2 == 0)
            {
                answer[0] += 1;
            }
            else
            {
                answer[1] += 1;
            }
        }
        return answer;
    }
}
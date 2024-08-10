using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = numbers;
        int temp = 0;
        if(direction == "left")
        {
            temp = answer[0];
            for(int i = 0; i < answer.Length - 1;i++)
            {
                answer[i] = answer[i+1];
            }
            answer[answer.Length-1] = temp;
        }
        else if(direction == "right")
        {
            temp = answer[answer.Length-1];
            for(int i = answer.Length-1; i > 0;i--)
            {
                answer[i] = answer[i-1];
            }
            answer[0] = temp;
        }
        return answer;
    }
}
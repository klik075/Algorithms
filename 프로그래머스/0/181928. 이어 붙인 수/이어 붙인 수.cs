using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int answer1 = 0;
        int answer2 = 0;
        int num1 = 10;
        int num2 = 10;
        foreach(var item in num_list)
        {
            if(item % 2 == 0)//짝수
            {
                answer1 *= num1;
                answer1 += item;
            }
            else//홀수
            {
                answer2 *= num2;
                answer2 += item;
            }
        }
        answer = answer1 + answer2;
        return answer;
    }
}
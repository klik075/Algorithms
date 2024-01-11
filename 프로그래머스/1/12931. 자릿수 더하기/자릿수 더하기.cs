using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int number = n;
        int temp = 0;
        int i =1;
        while(number / i != 0)
        {
            temp = number/i;
            answer += temp % 10;
            i = i * 10;
        }
        return answer;
    }
}
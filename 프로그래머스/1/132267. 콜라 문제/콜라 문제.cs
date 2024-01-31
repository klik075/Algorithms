using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int temp = 0;
        while(n >= a)//전체 콜라의 수 빈병 a개를 주면 b개를 준다. n은 빈병의 개수
        {
            temp = n/a;
            n = n - (temp * a) + (temp * b);
            answer += temp * b;   
        }
        return answer;
    }
}
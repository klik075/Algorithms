using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        foreach(var item in control)
        {
            if(item == 'w')
            {
                answer += 1;
            }
            else if(item == 's')
            {
                answer -= 1;
            }
            else if(item == 'd')
            {
                answer += 10;
            }
            else if(item == 'a')
            {
                answer -= 10;
            }
        }
        return answer;
    }
}
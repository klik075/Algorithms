using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        char[] str = n.ToString().ToCharArray();
        foreach(var num in str)
        {
            answer += num - '0';
        }
        return answer;
    }
}
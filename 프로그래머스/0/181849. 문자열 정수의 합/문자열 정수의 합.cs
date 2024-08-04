using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        char[] arr = num_str.ToCharArray();
        foreach(var num in arr)
        {
            answer += num - '0';
        }
        return answer;
    }
}
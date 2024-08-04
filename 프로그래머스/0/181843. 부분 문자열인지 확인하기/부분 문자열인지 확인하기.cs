using System;

public class Solution {
    public int solution(string my_string, string target) {
        int answer = 0;
        answer = my_string.Contains(target) == true ? 1 : 0;
        return answer;
    }
}
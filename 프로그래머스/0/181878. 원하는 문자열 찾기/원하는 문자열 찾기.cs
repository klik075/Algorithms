using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        answer = myString.ToLower().Contains(pat.ToLower())? 1: 0;
        return answer;
    }
}
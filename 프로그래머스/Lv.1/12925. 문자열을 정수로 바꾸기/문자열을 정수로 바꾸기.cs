using System;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        Int32.TryParse(s,out answer);
        
        return answer;
    }
}
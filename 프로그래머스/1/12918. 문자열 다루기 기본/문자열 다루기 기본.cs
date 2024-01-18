using System;
public class Solution {
    public bool solution(string s) {
        bool answer = false;
        if(s.Length == 4 || s.Length == 6)
            answer = Int32.TryParse(s,out int result);
        
        return answer;
    }
}
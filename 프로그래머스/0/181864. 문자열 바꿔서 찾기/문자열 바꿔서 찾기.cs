using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string temp = myString.Replace('A','@');
        temp = temp.Replace('B','A');
        temp = temp.Replace('@','B');
        answer = temp.Contains(pat) == true ? 1 : 0;
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string str = "";
        str += a.ToString();
        str += b.ToString();
        answer = int.Parse(str) > 2 * a * b ? int.Parse(str) : 2 * a * b;
        
        return answer;
    }
}
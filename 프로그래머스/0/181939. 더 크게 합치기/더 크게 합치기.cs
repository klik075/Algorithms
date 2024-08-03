using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string arr = "";
        int case1 = int.Parse(a.ToString() + b.ToString());
        int case2 = int.Parse(b.ToString() + a.ToString());
        answer = case1 > case2 ? case1 : case2;
        return answer;
    }
}
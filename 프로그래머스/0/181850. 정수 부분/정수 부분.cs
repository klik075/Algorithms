using System;

public class Solution {
    public int solution(double flo) {
        int answer = 0;
        string s = flo.ToString();
        string result = "";
        for(int i = 0; i< s.Length;i++)
        {
            if(s[i] == '.')
            {
                break;
            }
            else
            {
                result += s[i];
            }
        }
        answer = int.Parse(result);
        return answer;
    }
}
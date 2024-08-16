using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        string sub = my_string.Substring(s,e-s+1);
        for(int i = 0 ; i < my_string.Length;i++)
        {
            if(s <= i && i <= e)
                answer += sub[e-i];
            else
                answer += my_string[i];
        }
        return answer;
    }
}
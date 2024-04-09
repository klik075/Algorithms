using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string same = "";
        string different = "";
        char start = ' ';
        for (int i = 0; i < s.Length; i++)
        {
            if (same.Length == 0 && different.Length == 0)
            {
                start = s[i];
            }

            if (start == s[i])
            {
                same += s[i].ToString();
            }
            else if (start != s[i])
            {
                different += s[i].ToString();
            }

            if (same.Length == different.Length)
            {
                same = "";
                different = "";
                answer++;
                continue;
            }
            else if (i == s.Length - 1)
            {
                answer++;
            }
        }
        return answer;
    }
}
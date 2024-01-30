using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int result = 0;
        for(int i = 0 ; i < s.Length; i++)
        {
            result = -1;
            for(int j = i-1; j >= 0;j--)
            {
                if(s[j] == s[i])
                {
                    result = i-j;
                    answer[i] = result;
                    break;
                }
            }
            answer[i] = result;
        }
        return answer;
    }
}
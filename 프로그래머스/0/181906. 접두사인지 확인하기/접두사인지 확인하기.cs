using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        if(my_string.Length < is_prefix.Length)
        {
            answer = 0;
        }
        else
        {
            answer = 1;
            for(int i = 0; i < is_prefix.Length; i++)
            {
                if(is_prefix[i] != my_string[i])
                {
                    answer = 0;
                    break;
                }
            }
        }
        
        return answer;
    }
}
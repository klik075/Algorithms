using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        for(int i = 0 ; i < my_string.Length; i++)
        {
            string str = my_string.Substring(i,my_string.Length-i);
            if(str == is_suffix)
            {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}
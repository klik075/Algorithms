using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        int temp = 0;
        for(int i = 0 ; i < n_str.Length;i++)
        {
            if(n_str[i] == '0')
            {
                temp = i+1;
                continue;
            }
            else if(temp == i)
            {
                answer = n_str.Substring(i,n_str.Length-i);
                break;
            }
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        for(int i = 0 ; i < my_string.Length;i++)
        {
            if((i + 1) % m == 0)
            {
                sb.Append(my_string[i-(m-c)]);
            }
        }
        answer = sb.ToString();
        return answer;
    }
}
using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        StringBuilder sb = new StringBuilder("");
        for(int i = 0 ; i < k; i++)
        {
            sb.Append(my_string);
        }
        answer = sb.ToString();
        return answer;
    }
}
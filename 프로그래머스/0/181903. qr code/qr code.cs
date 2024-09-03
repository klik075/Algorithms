using System;
using System.Text;
public class Solution {
    public string solution(int q, int r, string code) {
        StringBuilder sb = new StringBuilder();
        int length = code.Length;
        for(int i = 0 ; i < length ; i++)
        {
            if(i % q == r)
                sb.Append(code[i]);
        }
        return sb.ToString();
    }
}
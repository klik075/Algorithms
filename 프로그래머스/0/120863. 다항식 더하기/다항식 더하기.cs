using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string[] elem = polynomial.Split(' ');
        int xCount = 0;
        int numCount = 0;
        foreach(string s in elem)
        {
            if(s.Contains('x'))
            {
                if(s[0] == 'x')
                    xCount++;
                else
                {
                    String num = s.Replace("x", "");
                    xCount += Int32.Parse(num);
                }
            }
            else if(s != "+")
                numCount += Int32.Parse(s);
        }
        if(xCount != 0)
        {
            if(xCount == 1)
                answer += "x";
            else
                answer += $"{xCount}x";

            if(numCount != 0)
                answer += " + ";
        }
        
        if(numCount != 0)
            answer += $"{numCount}";
        
        return answer;
    }
}
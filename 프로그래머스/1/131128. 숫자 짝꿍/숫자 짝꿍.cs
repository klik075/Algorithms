using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string X, string Y) {
        List<char> answer = new List<char> ();
        List<char> x = X.ToList();
        List<char> y = Y.ToList();
        x.Sort();
        y.Sort();
        
        int idxX = 0;
        int idxY = 0;
        while (idxX < x.Count() && idxY < y.Count())
        {
            if (x[idxX] == y[idxY])
            {
                answer.Add(x[idxX]);
                ++idxX;
                ++idxY;
            }
            else if (x[idxX] > y[idxY])
                ++idxY;
            else //  x[idxX] < y[idxY]
                ++idxX;
        }
        
        if (answer.Count() == 0)
            return "-1";
        
        if (answer[answer.Count() - 1] == '0')
            return "0";
        
        answer.Reverse();
        return (new string(answer.ToArray()));
    }
}
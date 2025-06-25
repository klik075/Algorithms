using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        foreach(string d in dic)
        {
            bool isin = true;
            foreach(string s in spell)
            {
                if(!d.Contains(s))
                {
                    isin = false;
                    break;
                }
            }
            if(isin)
            {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}
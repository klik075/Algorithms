using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long temp = 0;
        long target = Int64.Parse(p);
        for(int i = 0 ; i< t.Length-p.Length+1;i++)
        {
            temp = Int64.Parse(t.Substring(i,p.Length));
            if(target >= temp)
                answer += 1;
        }
        return answer;
    }
}
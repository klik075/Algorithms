using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for(int i = 0 ; i < myString.Length - pat.Length +1;i++)
        {
            string sub = myString.Substring(i,pat.Length);
            if(sub == pat)
                answer++;
        }
        return answer;
    }
}
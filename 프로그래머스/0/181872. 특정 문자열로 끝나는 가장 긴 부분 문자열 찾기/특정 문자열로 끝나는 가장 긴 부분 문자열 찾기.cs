using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        for(int i = 0 ; i < myString.Length;i++)
        {
            string sub = myString.Substring(0,i+1);
            if(sub.EndsWith(pat) == true)
            {
                answer = sub;
            }
        }
        return answer;
    }
}
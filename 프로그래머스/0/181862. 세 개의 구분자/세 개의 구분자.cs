using System;

public class Solution {
    public string[] solution(string myStr) {
        myStr = myStr.Replace("a"," ").Replace("b", " ").Replace("c"," ");
        string[] answer = myStr.Split(" ",System.StringSplitOptions.RemoveEmptyEntries);
         if(answer.Length == 0)
         {
             answer = new string[1];
             answer[0] = "EMPTY";
         }
            
        return answer;
    }
}
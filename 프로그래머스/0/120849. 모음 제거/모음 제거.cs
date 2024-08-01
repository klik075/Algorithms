using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(var character in my_string)
        {
            if(character == 'a' || character == 'e' ||character == 'i' ||character == 'o' ||character == 'u')
            {
                continue;
            }
            else
            {
                answer += character;
            }
        }
        return answer;
    }
}
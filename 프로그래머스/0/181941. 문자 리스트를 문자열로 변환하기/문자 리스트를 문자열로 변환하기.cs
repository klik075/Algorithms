using System;

public class Solution {
    public string solution(string[] arr) {
        string answer = "";
        for(int i = 0 ; i < arr.Length ; i++)
        {
            char[] ch = arr[i].ToCharArray();
            answer += ch[0];
        }
        return answer;
    }
}
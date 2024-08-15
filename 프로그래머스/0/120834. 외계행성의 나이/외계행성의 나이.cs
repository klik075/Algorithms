using System;

public class Solution {
    public string solution(int age) {
        char[] ageArr = age.ToString().ToCharArray();
        string answer = "";
        for(int i = 0 ; i < ageArr.Length; i++)
        {
            int result = ageArr[i] - '0';
            answer += (char)(result + 97);
        }
        return answer;
    }
}
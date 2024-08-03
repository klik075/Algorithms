using System;

public class Solution {
    public int[] solution(string myString) {
        string[] s = myString.Split("x");
        int[] answer = new int[s.Length];
        for(int i = 0; i < answer.Length ; i++)
        {
            answer[i] = s[i].Length;
        }
        return answer;
    }
}
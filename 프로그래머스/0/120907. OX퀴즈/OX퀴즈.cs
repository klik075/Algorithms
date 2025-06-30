using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        
        for(int i = 0; i < quiz.Length; i++)
        {
            string[] arr = quiz[i].Split(' ');
            int num1 = Int32.Parse(arr[0]);
            int num2 = Int32.Parse(arr[2]);
            int result = Int32.Parse(arr[4]);
            
            if(arr[1] == "-")
                answer[i] = num1 - num2 == result ? "O" : "X";
            else
                answer[i] = num1 + num2 == result ? "O" : "X";
        }
        
        return answer;
    }
}
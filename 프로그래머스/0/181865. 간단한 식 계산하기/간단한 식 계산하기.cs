using System;

public class Solution {
    public int solution(string binomial) {
        string[] arr = binomial.Split(" ");
        int answer = 0;
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[2]);
        if(arr[1] == "+")
        {
            answer = a + b;
        }
        else if(arr[1] == "-")
        {
            answer = a - b;
        }
        else if(arr[1] == "*")
        {
            answer = a * b;
        }
        return answer;
    }
}
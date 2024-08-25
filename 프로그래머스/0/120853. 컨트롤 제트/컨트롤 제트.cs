using System;

public class Solution {
    public int solution(string s) {
        string[] arr = s.Split(" ");
        int answer = 0;
        for(int i = 0 ; i < arr.Length;i++)
        {
            if(arr[i] == "Z")
            {
                answer -= int.Parse(arr[i-1]);
            }
            else
            {
                answer += int.Parse(arr[i]);
            }
        }
        return answer;
    }
}
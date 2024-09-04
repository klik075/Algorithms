using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int length = my_str.Length;
        string[] answer = length % n == 0 ? new string[length/n] : new string[length/n + 1];
        for(int i = 0 ; i < length;i++)
        {
            answer[i/n] += my_str[i];
        }
        return answer;
    }
}
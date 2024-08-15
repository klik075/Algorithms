using System;

public class Solution {
    public int solution(string number) {
        char[] arr = number.ToCharArray();
        int answer = 0;
        for(int i = 0 ; i < arr.Length; i++)
        {
            answer += arr[i] - '0';
        }    
        return answer%9;
    }
}
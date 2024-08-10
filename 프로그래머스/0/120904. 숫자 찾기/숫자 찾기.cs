using System;

public class Solution {
    public int solution(int num, int k) {
        char[] arr = num.ToString().ToCharArray();
        int answer = -1;
        for(int i = 0; i < arr.Length;i++)
        {
            if(arr[i] - '0' == k)
            {
                answer = i + 1;
                break;
            }
        } 
        return answer;
    }
}
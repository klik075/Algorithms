using System;

public class Solution {
    public int solution(int order) {
        char[] arr = order.ToString().ToCharArray();
        int answer = 0;
        for(int i = 0 ; i < arr.Length;i++)
        {
            if(arr[i] != '0' && (arr[i] -'0') % 3 == 0)
                answer++;
        }  
        return answer;
    }
}
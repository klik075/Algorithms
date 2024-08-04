using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;
        foreach(var num in num_list)
        {
            if(num == n)
                answer = 1;
        }
        return answer;
    }
}
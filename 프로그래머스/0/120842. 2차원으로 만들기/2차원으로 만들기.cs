using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n,n];
        for(int j = 0; j < num_list.Length/n;j++)
        {
            for(int i = 0 ; i < n; i++)
            {
                answer[j,i] = num_list[j*n + i];
            }
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = arr;
        for(int i = 0 ; i < queries.GetLength(0); i++)
        {
            int x = queries[i,0];
            int y = queries[i,1];
            int temp = answer[x];
            answer[x] = answer[y];
            answer[y] = temp;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = arr;
        for(int i = 0 ; i < queries.GetLength(0);i++)
        {
            int s = queries[i,0];
            int e = queries[i,1];
            for(int j = s ;j <= e;j++)
            {
                if(0 <= j && j <= arr.Length)
                {
                    arr[j] += 1;
                }
            }
        }
        return answer;
    }
}
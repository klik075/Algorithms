using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        Array.Fill(answer,Int32.MaxValue);
        
        for(int j = 0; j < queries.GetLength(0); j++)
        {
            int s = queries[j,0];
            int e = queries[j,1];
            int k = queries[j,2];
            
            for(int i = s; i <= e; i++)
            {
                if(arr[i] > k)
                {
                    if(arr[i] < answer[j])
                        answer[j] = arr[i];
                }
            }
            if(answer[j] == Int32.MaxValue)
                answer[j] = -1;
        }
        return answer;
    }
}
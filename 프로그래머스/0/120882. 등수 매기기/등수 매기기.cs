using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[,] score) {
        List<int> answer = new List<int>();
        List<int> arr = new List<int>();
        for(int i = 0; i < score.GetLength(0); i++)
            arr.Add(score[i,0] + score[i,1]);
        
        foreach(int elem in arr)
        {
            int rank = 0;
            foreach(int comp in arr)
            {
                if(comp > elem)
                    rank++;
            }
            answer.Add(rank+1);
        }
        return answer.ToArray();
    }
}
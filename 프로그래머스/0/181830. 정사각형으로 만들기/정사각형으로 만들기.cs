using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int colSize = arr.GetLength(0);
        int rowSize = arr.GetLength(1);
        int size = colSize > rowSize ? colSize : rowSize;
        int[,] answer = new int[size,size];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                answer[i,j] = arr[i,j];
        }
        return answer;
    }
}
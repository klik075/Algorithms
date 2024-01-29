using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int length = commands.GetLength(0);
        int[] answer = new int[length];
        List<int> temp = new List<int>();
        for(int i = 0 ; i < length;i++)
        {
            
            for(int j = commands[i,0]-1 ; j <= commands[i,1]-1;j++)
            {   
                temp.Add(array[j]);
            }
            temp.Sort();
            answer[i] = temp[commands[i,2]-1];
            temp.Clear();
        }
        return answer;
    }
}
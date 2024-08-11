using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        int[] arr = new int[2];
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>(); 
        List<int> key = new List<int>();
        for(int i =0; i < lines.GetLength(0);i++)
        {
            for(int j = 0 ; j < lines.GetLength(1);j++)
            {
                arr[j] = lines[i,j];
            }
            for(int z = arr[0]; z <= arr[1]; z++)
            {
                if(!key.Contains(z))
                {
                    key.Add(z);
                }
                if(!dict.ContainsKey(z))
                {
                    dict[z] = new List<int>();
                }
                dict[z].Add(i);
            }
        }
        key.Sort();
        for(int i = 0 ; i < key.Count; i++)
        {
            if(dict[key[i]].Count != 1)
            {
                if(dict.ContainsKey(key[i]+1))
                {
                    int count = 0;
                    for(int k = 0; k < dict[key[i]].Count;k++)
                    {
                        if(dict[key[i]+1].Contains(dict[key[i]][k]))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                    if(count >= 2)
                    {
                        answer++;
                    }
                }
            }                   
        }    
        return answer;  
    }
}
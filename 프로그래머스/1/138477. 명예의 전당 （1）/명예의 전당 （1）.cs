using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> topK = new List<int>();
        for(int i = 0 ; i < score.Length;i++)
        {
            for(int j = 0; j < k; j ++)
            {
                if(topK.Count < k)
                {
                    topK.Add(score[i]);
                    topK.Sort();
                    break;
                }
                else
                {
                    if(score[i] > topK[j])
                    {
                        if(j == k-1)
                        {
                            topK.RemoveAt(0);
                            topK.Add(score[i]);
                        }
                        continue;
                    }                  
                    else
                    {
                        if(score[i] > topK[0])
                        {
                            topK.Insert(j,score[i]);
                            topK.RemoveAt(0);
                            break;
                        }
                        else
                            break;
                    }
                }   
            }
            answer[i] = topK[0]; 
        }
        return answer;
    }
}
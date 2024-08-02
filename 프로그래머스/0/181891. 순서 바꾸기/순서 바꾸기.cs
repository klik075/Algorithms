using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        List<int> arr = new List<int>();
        for(int i = 0 ; i<num_list.Length;i++)
        {
            if(i<n)
                arr.Add(num_list[i]);
            else
            {
                arr.Insert(i-n,num_list[i]);
            }
        }
        answer = arr.ToArray();
        return answer;
    }
}
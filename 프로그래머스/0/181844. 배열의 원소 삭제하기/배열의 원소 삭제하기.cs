using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> list = new List<int>();
        for(int i = 0 ; i< arr.Length;i++)
        {
            list.Add(arr[i]);
            for(int j = 0; j < delete_list.Length; j++)
            {
                if(arr[i] == delete_list[j])
                {
                    list.Remove(arr[i]);
                    break;
                }
            }
        }
        
        int[] answer = list.ToArray();
        return answer;
    }
}
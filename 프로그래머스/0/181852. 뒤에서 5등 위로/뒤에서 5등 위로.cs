using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length - 5];
        List<int> arr = new List<int>();
        foreach(var num in num_list)
        {
            arr.Add(num);
        }
        arr.Sort();
        for(int i = 0; i< 5;i++)
        {
            arr.RemoveAt(0);
        }
        answer = arr.ToArray();
        return answer;
    }
}
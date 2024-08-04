using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length - 5];
        List<int> arr = num_list.ToList();
        arr.Sort();
        for(int i = 0; i< 5;i++)
        {
            arr.RemoveAt(0);
        }
        answer = arr.ToArray();
        return answer;
    }
}
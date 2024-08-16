using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        List<int> arr = emergency.ToList();
        arr.Sort();
        arr.Reverse();
        for(int i = 0 ; i < emergency.Length;i++)
        {
            for(int j = 0 ; j < arr.Count;j++)
            {
                if(emergency[i] == arr[j])
                    answer[i] = j+1;
            }
        }
        return answer;
    }
}
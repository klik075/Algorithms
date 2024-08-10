using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> result = new List<int>();
        int target =0;
        for(int i =0;i<arr.Length;i++)
        {
            target = arr[i];
            for(int j = 0 ; j < target; j++)
            {
                result.Add(target);
            }
        }
        return result.ToArray();
    }
}
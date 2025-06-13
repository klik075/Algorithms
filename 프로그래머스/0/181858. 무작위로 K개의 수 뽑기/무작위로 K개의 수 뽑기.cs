using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> answer = new List<int>();
        HashSet<int> set = new HashSet<int>();
        int temp = k;
        foreach(int elem in arr)
        {
            if(!set.Contains(elem))
            {
                set.Add(elem);
                answer.Add(elem);
                temp--;
            }
            if(temp == 0)
                break;
        }
        if(answer.Count != k)
        {
            for(int i = answer.Count; i < k; i++)
                answer.Add(-1);
        }
        return answer.ToArray();
    }
}
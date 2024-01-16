using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> list = arr.ToList();
        list.Sort();
        int min = list[list.Count-1];
        int minIdx =0;
        for(int i =0;i< arr.Length;i++)
        {
            if(min >= arr[i])
            {
                minIdx = i;
                min = arr[i];
            }
        }
        list = arr.ToList();
        list.RemoveAt(minIdx);
        if(list.Count == 0)
            list.Add(-1);
        answer = list.ToArray();
        return answer;
    }
}
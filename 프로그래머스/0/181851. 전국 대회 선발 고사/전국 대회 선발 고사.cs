using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        List<KeyValuePair<int, int>> result = new List<KeyValuePair<int, int>>();
        for(int i = 0; i < attendance.Length; i++)
        {
            if(attendance[i])
                result.Add(new KeyValuePair<int, int>(rank[i], i));
        }
        result.Sort((a, b) => a.Key.CompareTo(b.Key));
        answer = 10000 * result[0].Value + 100 * result[1].Value + result[2].Value;
        return answer;
    }
}
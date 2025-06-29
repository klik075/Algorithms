using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[numlist.Length];
        List<KeyValuePair<int,int>> data = new List<KeyValuePair<int,int>>();
        
        for(int i = 0; i < numlist.Length; i++)
            data.Add(new KeyValuePair<int,int>(Math.Abs(n-numlist[i]), -numlist[i]));
            
        data.Sort((pair1, pair2) => {
        int valueComparison = pair1.Key.CompareTo(pair2.Key);
        if (valueComparison != 0)
        {
            return valueComparison;
        }
            return pair1.Value.CompareTo(pair2.Value);
        });
        
        for(int i = 0; i < data.Count; i++)
            answer[i] = Math.Abs(data[i].Value);
        
        return answer;
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string before, string after) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int answer = 1;
        for(int i = 0 ; i < before.Length;i++)
        {
            if(dict.ContainsKey(before[i]) == false)
            {
                dict[before[i]] = 0;
            }
            dict[before[i]] = dict[before[i]] + 1;
        }
        for(int i = 0 ; i < after.Length;i++)
        {
            if(dict.ContainsKey(after[i]) == false)
            {
                answer = 0;
                return answer;
            }
            dict[after[i]] = dict[after[i]] - 1;
        }
        foreach(var num in dict)
        {
            if(num.Value != 0)
            {
                answer = 0;
                break;
            }
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i = 0 ; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i])== false)
                dict[s[i]] = 0;
            
            dict[s[i]] = dict[s[i]] + 1;
        }
        foreach(var num in dict)
        {
            if(num.Value == 1)
            {
                answer += num.Key;
            }
        }
        answer = Sort(answer);
        return answer;
    }
    public String Sort(String input)
    {
        char[] chars = input.ToCharArray();
        Array.Sort(chars);
        return new String(chars);
    }
}
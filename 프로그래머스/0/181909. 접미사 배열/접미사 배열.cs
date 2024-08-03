using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_string) {
        List<string> list = new List<string>();
        for(int i = 0 ; i < my_string.Length;i++)
        {
            list.Add(my_string.Substring(i,my_string.Length - i));
        }
        list.Sort();
        string[] answer = list.ToArray();
        return answer;
    }
}
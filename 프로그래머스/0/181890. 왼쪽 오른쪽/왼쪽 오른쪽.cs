using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] str_list) {
        List<string> answer = new List<string>();
        bool isTrigger = false;
        for(int i = 0 ; i < str_list.Length;i++)
        {
            if(str_list[i] == "l" && isTrigger == false)
            {
                break;
            }
            else if(str_list[i] == "r" && isTrigger == false)
            {
                isTrigger = true;
                answer.Clear();
                continue;
            }
            else
            {
                answer.Add(str_list[i]);
            }
        }
        if(answer.Count == str_list.Length)
            answer.Clear();
        return answer.ToArray();
    }
}
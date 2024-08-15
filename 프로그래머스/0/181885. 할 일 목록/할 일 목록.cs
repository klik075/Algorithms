using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        List<string> arr = new List<string>();
        for(int i = 0 ; i < finished.Length;i++)
        {
            if(finished[i] == false)
                arr.Add(todo_list[i]);
        }
        return arr.ToArray();
    }
}
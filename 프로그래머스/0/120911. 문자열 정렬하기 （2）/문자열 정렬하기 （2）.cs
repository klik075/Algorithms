using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string my_string) {
        List<char> arr= my_string.ToLower().ToList();
        string answer = "";
        arr.Sort();
        for(int i = 0 ; i < arr.Count; i++)
        {
            answer += arr[i];
        }
    
        return answer;
    }
}
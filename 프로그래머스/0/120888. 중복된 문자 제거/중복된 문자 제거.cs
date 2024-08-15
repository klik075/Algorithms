using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string my_string) {
        string answer = "";
        Dictionary<char,bool> arr = new Dictionary<char,bool>();
        for(int i = 0; i < my_string.Length; i++)
        {
            if(!arr.ContainsKey(my_string[i]))
            {
                arr[my_string[i]] = true;
                answer += my_string[i];
            }
        }
        return answer;
    }
}
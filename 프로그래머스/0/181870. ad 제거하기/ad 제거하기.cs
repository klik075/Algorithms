using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strArr) {
        List<string> arr = new List<string>();
        foreach(var str in strArr)
        {
            arr.Add(str);
            if(str.Contains("ad"))
            {
                arr.Remove(str);
            }
        }
        
        string[] answer = arr.ToArray();
        return answer;
    }
}
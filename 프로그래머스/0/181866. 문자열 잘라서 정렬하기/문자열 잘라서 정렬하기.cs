using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x',StringSplitOptions.RemoveEmptyEntries);
        List<string> arr = answer.ToList<string>();
        arr.Sort();
        return arr.ToArray();
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        List<string> arr = new List<string>{
        "zero", "one", "two", "three", "four", "five",
        "six", "seven", "eight", "nine"
    };
        for(int i = 0; i < arr.Count; i++)
            numbers = numbers.Replace(arr[i],i.ToString());
        
        answer = Int64.Parse(numbers);
        return answer;
    }
}
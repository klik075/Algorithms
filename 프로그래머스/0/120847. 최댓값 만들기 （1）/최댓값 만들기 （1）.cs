using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        List<int> arr = numbers.ToList();
        arr.Sort();
        answer = arr[arr.Count - 1] * arr[arr.Count - 2];
        return answer;
    }
}
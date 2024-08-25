using System;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
        int[] arr = new int[31];
        int max = 0;
        for(int i = 0 ; i < strArr.Length; i++)
        {
            arr[strArr[i].Length] += 1;
        }
        max = arr.Max();
        return max;
    }
}
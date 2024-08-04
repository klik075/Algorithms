using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 1;
        int[] arr = new int[box.Length];
        for(int i = 0 ; i < box.Length; i++)
        {
            arr[i] = box[i]/n;
        }
        foreach(var num in arr)
        {
            answer *= num;
        }
        return answer;
    }
}
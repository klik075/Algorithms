using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        foreach(var v in array)
        {   
            if(v > height)
                answer++;
        }
        return answer;
    }
}
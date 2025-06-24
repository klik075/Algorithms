using System;

public class Solution {
    public int solution(int[] sides) {
        int i = 1;
        int max = Math.Max(sides[0], sides[1]);
        int min = Math.Min(sides[0], sides[1]);
        int answer = (max + min - 1) - (max - min);
        
        return answer;
    }
}
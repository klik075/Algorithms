using System;
using System.Linq;
public class Solution {
    public int solution(int[] sides) {
        int max = 0;
        int sum = 0;
        for(int i = 0 ; i < sides.Length;i++)
        {
            if(sides[i] > max)
                max = sides[i];
            sum += sides[i];
        }
        sum -= max;
        int answer = max < sum ? 1 : 2;
        return answer;
    }
}
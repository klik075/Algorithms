using System.Collections.Generic;
public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] {};
        List<int> arr = new List<int>();
        long x =1;
        long temp;
        while(n/x != 0)
        {
            temp = (n/x);
            arr.Add((int)(temp%10));
            x = x* 10;
        }
        answer = arr.ToArray();
        return answer;
    }
}
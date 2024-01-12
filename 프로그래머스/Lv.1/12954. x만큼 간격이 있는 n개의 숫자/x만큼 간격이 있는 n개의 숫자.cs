using System.Collections.Generic;
public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[]{};
        List<long> arr = new List<long>();
        for(int i = 1;i < n +1 ;i++)
        {
            arr.Add((long)x * i);
        }
        answer = arr.ToArray();
        return answer;
    }
}
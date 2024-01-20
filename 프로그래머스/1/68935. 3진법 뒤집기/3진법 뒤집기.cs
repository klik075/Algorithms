using System;

public class Solution {
    public long solution(int n) {
        long answer = 0;
        long temp =0;
        long div = 1;
        long multiple = 1;
        string arr = "";
        
        while(n != 0)
        {
            arr += (n%3).ToString();
            n = n/3;
        }
        temp = Int64.Parse(arr);
        while(temp / multiple != 0)
        {
            answer += ((temp / multiple) % 10) * div;
            multiple *= 10;
            div *= 3;
        }
        return answer;
    }
}
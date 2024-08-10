using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> arr = new List<int>();
        for(int i = 1 ; i <= n;i++)
        {
            if(n % i == 0)
                arr.Add(i);
        }
        return arr.ToArray();
    }
}
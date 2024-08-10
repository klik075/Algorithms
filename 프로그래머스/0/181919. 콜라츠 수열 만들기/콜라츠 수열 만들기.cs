using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> arr = new List<int>();
        arr.Add(n);
        while(n > 1)
        {
            if(n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = (3 * n) + 1;
            }
            arr.Add(n);
        }
        return arr.ToArray();
    }
}
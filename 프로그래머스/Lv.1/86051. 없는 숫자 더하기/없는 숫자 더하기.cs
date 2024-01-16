using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        List<int> arr = numbers.ToList();
        for(int i = 0;i<10;i++)
        {
            answer += i;
            for(int j = 0;j<arr.Count;j++)
            {
                if(arr[j] == i)
                {
                    answer -= i;
                    break;
                }
            }
        }
        return answer;
    }
}
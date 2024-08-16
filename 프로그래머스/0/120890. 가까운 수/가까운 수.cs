using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        List<int> arr = array.ToList();
        arr.Sort();
        int max = Int32.MaxValue;
        for(int i = 0 ; i < arr.Count; i++)
        {
            int num = n - arr[i];
            if(num < 0)//부호 양수로
                num *= -1;
            
            if(num < max)//최소 결정
            {
                max = num;
                answer = arr[i];
            }
        }
        return answer;
    }
}
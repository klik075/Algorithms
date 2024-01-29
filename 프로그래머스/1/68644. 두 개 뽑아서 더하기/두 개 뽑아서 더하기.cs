using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> arr = new List<int>();
        int temp = 0;
        for(int i = 0; i < numbers.Length-1;i++)
        {
            for(int j = i + 1; j < numbers.Length;j++)
            {
                temp = numbers[i] + numbers[j];
                if(arr.Contains(temp))
                    continue;
                else
                    arr.Add(temp);
            }
        }
        arr.Sort();
        answer = arr.ToArray();
        return answer;
    }
}
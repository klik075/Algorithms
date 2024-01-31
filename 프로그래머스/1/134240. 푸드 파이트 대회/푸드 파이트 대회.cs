using System;
using System.Collections.Generic;
public class Solution {
    public string solution(int[] food) {
        string answer = "";
        List<int> arr = new List<int>();
        int temp = 0;
        for(int i = 1 ; i < food.Length;i++)
        {
            temp = food[i]/2;
            for(int j = 0; j < temp;j++)
            {
                arr.Insert(arr.Count/2,i);
                arr.Insert((arr.Count/2)+1,i);
            }
        }
        arr.Insert(arr.Count/2,0);
        foreach(int i in arr)
            answer += i;
        return answer;
    }
}
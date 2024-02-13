using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[]{};
        int[] one = new int[]{1,2,3,4,5};
        int[] two = new int[]{2,1,2,3,2,4,2,5};
        int[] three = new int[]{3,3,1,1,2,2,4,4,5,5};
        int[] arr = new int[]{0,0,0};
        int max = 0;
        List<int> result = new List<int>();
        for(int i = 0 ; i < answers.Length;i++)
        {
            if(one[i%one.Length] == answers[i])
                arr[0]++;
            if(two[i%two.Length] == answers[i])
                arr[1]++;
            if(three[i%three.Length] == answers[i])
                arr[2]++;
        }
        foreach(int num in arr)
        {
            if(max < num)
                max = num;
        }
        for(int i = 0 ; i < arr.Length; i++)
        {
            if(arr[i] == max)
                result.Add(i+1);
        }
        answer = result.ToArray();
        return answer;
    }
}

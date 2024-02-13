using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[]{};
        int[] one = new int[]{1,2,3,4,5};
        int[] two = new int[]{2,1,2,3,2,4,2,5};
        int[] three = new int[]{3,3,1,1,2,2,4,4,5,5};
        int[] arr = new int[]{0,0,0};
        
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
        if(arr.Max() == arr[0]) result.Add(1);
        if(arr.Max() == arr[1]) result.Add(2);
        if(arr.Max() == arr[2]) result.Add(3);
        answer = result.ToArray();
        return answer;
    }
}

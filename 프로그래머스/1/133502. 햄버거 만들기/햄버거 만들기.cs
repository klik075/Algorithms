using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();
        int count = 0;
        foreach(var num in ingredient)
        {
            list.Add(num);
            count = list.Count;
            if(count >= 4)
            {
                if(list[count-4] == 1 && list[count-3] == 2 && 
                list[count-2] == 3&& list[count-1]==1 )
                {
                    answer++;
                    list.RemoveRange(count-4,4);
                }
            }
        }
        
        return answer;
    }
}
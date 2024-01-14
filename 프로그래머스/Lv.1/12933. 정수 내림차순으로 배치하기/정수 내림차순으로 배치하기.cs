using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        string answer_s = "";
        List<int> list = new List<int>();
        long x =1;
        int result;
        while(n/x != 0)
        {
            result = (int)((n/x)%10); 
            list.Add(result);
            x = x * 10;
        }
        
        List<int> newList = list.OrderByDescending(i => i).ToList();
        
        for(int i = 0 ; i < newList.Count; i++)
        {
            answer_s = answer_s + newList[i].ToString();
        }
        answer = Int64.Parse(answer_s);
        return answer;
    }
}
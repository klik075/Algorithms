using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int num, int total) {
        List<int> answer = new List<int>();
        float comp;
        
        if(num % 2 != 0)
        {
            comp = total/num;
            answer.Add((int)comp);
            for(int i = 1; i <= num / 2; i++)
            {
                answer.Add((int)comp - i);
                answer.Add((int)comp + i);
            }
        }
        else
        {
            comp = (float)total/num;
            for(int i = 1; i <= num / 2; i++)
            {
                answer.Add((int)Math.Ceiling(comp - i));
                answer.Add((int)Math.Floor(comp + i));
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}
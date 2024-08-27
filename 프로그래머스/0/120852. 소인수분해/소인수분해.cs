using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        for(int i = 2; i <= n; i++)
        {
            if(n % i == 0)//나눌 수 있고
            {
                int count = 0;
                for(int j = 1; j <= i;j++)
                {
                    if(i % j == 0)
                        count++;
                    
                    if(count > 2)
                    {
                        break;
                    }
                }
                if(count == 2)//소수인 것만
                    answer.Add(i);
            }
        }
        return answer.ToArray();
    }
}
using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        char[] a = A.ToCharArray();
        char[] b = B.ToCharArray();
        while(answer < a.Length)
        {
            bool check = true;
            
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    check = false;
                    break;
                }
            }
            
            if(check)
                break;
            
            answer++;
            char last = a[a.Length - 1];
            for(int i = a.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                    a[0] = last;
                else
                    a[i] = a[i - 1];
            }
        }
        return answer = answer >= a.Length ? -1 : answer;
    }
}
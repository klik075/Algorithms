using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        int col = n/w + 1;
        int[,] arr = new int[col, w];
        
        for(int i = 0; i < n; i++)
        {
            int mul = i / w; //몫
            int mod = i % w; //나머지
            int low = mul % 2 == 0 ? mod : w - 1 - mod;
            arr[col-1-mul, low] = i + 1;
        }
        int targetLow = ((num-1)/w) % 2 == 0 ? (num-1) % w : w - 1 - ((num-1) % w); 
        for(int i = 0; i < col; i++)
        {
            if(arr[i, targetLow] == 0)
                continue;
            else if(arr[i, targetLow] != num)
            {
                answer++;
                continue;
            }
            else
            {
                answer++;
                break;
            }
        }
        return answer;
    }
}
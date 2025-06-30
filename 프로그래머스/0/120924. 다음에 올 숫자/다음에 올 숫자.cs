using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        bool isAdd = true;
        int mul = 1;
        int dif = common[1] - common[0];
        int last = common[common.Length - 1];
        for(int i = 1; i < common.Length; i++)
        {
            if(common[i] != 0 && common[i-1] != 0)
                mul = common[i] / common[i-1];
            
            if(common[i] - common[i-1] == dif)
                isAdd = true;
            else
            {
                isAdd = false;
                break;
            }
        }
        answer = isAdd == true ? last + dif : last * mul;
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        bool isAdd = false;
        int mul = common[1] / common[0];
        int dif = common[1] - common[0];
        int last = common[common.Length - 1];
        for(int i = 1; i < common.Length; i++)
        {
            if(common[i] / common[i-1] == mul)
                isAdd = false;
            else
            {
                isAdd = true;
                break;
            }
        }
        answer = isAdd == true ? last + dif : last * mul;
        return answer;
    }
}
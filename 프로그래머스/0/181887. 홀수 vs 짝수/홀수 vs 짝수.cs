using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int even=0;
        int odd=0;
        for(int i = 0; i < num_list.Length;i++)
        {
            if(i % 2 == 0)
            {
                odd += num_list[i];
            }
            else
            {
                even += num_list[i];
            }
        }
        answer = odd > even ? odd : even;
        return answer;
    }
}
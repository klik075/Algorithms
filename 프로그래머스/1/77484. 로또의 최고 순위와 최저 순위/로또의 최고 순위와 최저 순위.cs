using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int max = 0;
        int min = 0;
        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
            {
                max++;
                continue;
            }
            for(int j =0;j < win_nums.Length;j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    min++;
                    break;
                }
            }
        }
        answer[0] = 7 - (min + max) <= 5 ? 7 - (min + max) : 6 ;
        answer[1] = 7 - min <= 5 ? 7 - min : 6;
        return answer;
    }
}
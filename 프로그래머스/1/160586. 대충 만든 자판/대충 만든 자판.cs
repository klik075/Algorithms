using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;
        int count = 0;
        for(int i = 0 ; i < targets.Length;i++)
        {
            for(int j = 0 ; j < targets[i].Length;j++)
            {
                count = Calculation(keymap,targets[i][j]);
                if(count == -1)
                {
                    sum = -1;
                    break;
                }
                else
                {
                    sum += count;
                }                
            }
            answer[i] = sum;
            sum = 0;
        }
        return answer;
    }
    public int Calculation(string[] keymap,char compare)
    {
        int min = -1;
        for(int i = 0 ; i < keymap.Length;i++)
        {
            for(int j = 0 ; j < keymap[i].Length; j++)
            {
                if(compare == keymap[i][j])
                {
                    if(min == -1)
                    {
                        min = j + 1;
                    }
                    else if(min > j)
                    {
                        min = j + 1;
                        break;
                    }
                }
            }
        }
        return min;
    }
}
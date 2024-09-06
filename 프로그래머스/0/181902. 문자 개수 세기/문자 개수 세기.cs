using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        for(int i = 0 ; i < my_string.Length;i++)
        {
            char num = my_string[i];
            if(65 <= num && num <= 90)
            {
                answer[num - 65] += 1;
            }
            else if(97 <= num && num <= 122)
            {
                answer[num - 97 + 26] += 1;
            }
        }
        return answer;
    }
}
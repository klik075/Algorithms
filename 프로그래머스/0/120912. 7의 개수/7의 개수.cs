using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        for(int i = 0 ; i < array.Length;i++)
        {
            string num = array[i].ToString();
            for(int j = 0 ; j < num.Length; j++)
            {
                if(num[j] == '7')
                    answer++;
            }
        }
        return answer;
    }
}
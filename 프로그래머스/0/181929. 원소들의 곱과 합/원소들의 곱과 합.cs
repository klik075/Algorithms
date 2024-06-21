using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int mul = 1;
        int com = 0;
        foreach(var item in num_list)
        {
            mul *= item;
            com += item;
        }
        answer = mul < com * com ? 1 : 0; 
        
        return answer;
    }
}
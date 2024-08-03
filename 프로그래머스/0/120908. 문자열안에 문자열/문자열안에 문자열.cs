using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        answer = str1.ToLower().Contains(str2.ToLower()) == true ? 1 : 2; 
        return answer;
    }
}
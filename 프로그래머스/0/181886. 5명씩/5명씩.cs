using System;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[names.Length%5 == 0 ? names.Length/5 : (names.Length/5) + 1];
        for(int i = 0; i < names.Length; i++)// 0 1 2 3 4 5 6
        {
            if(i % 5 == 0)
                answer[i/5] = names[i];
        }
        return answer;
    }
}
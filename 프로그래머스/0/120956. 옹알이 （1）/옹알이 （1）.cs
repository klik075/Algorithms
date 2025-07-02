using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        String[] list = new String[]{"aya","ye","woo","ma"};
        foreach(String s in babbling)
        {
            String temp = s;
            foreach(String target in list)
                temp = temp.Replace(target, " ");
            
            temp = temp.Trim();
            if(temp.Length == 0)
                answer++;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] words = new string[4] {"aya","ye","woo","ma"};
        
        for(int i = 0 ; i < babbling.Length;i++)
        {
            for(int j = 0 ; j < words.Length;j++)
            {
                string str = words[j] + words[j];
                babbling[i] = babbling[i].Replace(str,"@").Replace(words[j]," "); 
            }
            if(babbling[i].Trim().Length < 1)
                {
                    answer++;
                }
        }
        return answer;
    }
}
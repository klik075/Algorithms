using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<string,int> mbti = new Dictionary<string,int>()
        {
            {"R",0 }, {"T",0 },
            {"C",0 }, {"F",0 },
            {"J",0 }, {"M",0 },
            {"A",0 }, {"N",0 },  
        };
        int choice = 0;
        string temp = "";
        for(int i = 0 ; i < survey.Length;i++)
        {
            if(choices[i] > 4)
            {
                temp = survey[i][1].ToString();
                choice = choices[i] - 4;
            }
            else
            {
                temp = survey[i][0].ToString();
                choice = 4 - choices[i];
            }
            mbti[temp] += choice;
            
        }
        answer += mbti["R"] >= mbti["T"] ? "R" : "T";
        answer += mbti["C"] >= mbti["F"] ? "C" : "F";
        answer += mbti["J"] >= mbti["M"] ? "J" : "M";
        answer += mbti["A"] >= mbti["N"] ? "A" : "N";
        
        return answer;
    }
}
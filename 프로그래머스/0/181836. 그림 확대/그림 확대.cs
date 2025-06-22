using System;
using System.Linq;
public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[picture.Length * k];
        for(int i = 0; i < answer.Length; i++)
        {
            string temp = picture[i/k];
            string result = "";
            for(int j = 0; j < temp.Length; j++)
            {
                for(int m = 0; m < k; m++)
                {
                    char ch = temp[j];
                    result += ch;
                }
            }
            answer[i] = result;
        }
        return answer;
    }
}
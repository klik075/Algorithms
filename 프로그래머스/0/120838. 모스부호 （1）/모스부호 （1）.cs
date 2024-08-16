using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] morse = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."}; //a ~ z
        string[] arr = letter.Split(" ");
        for(int i = 0 ; i < arr.Length;i++)
        {
            for(int j = 0 ; j < morse.Length;j++)
            {
                if(arr[i] == morse[j])
                {
                    answer += (char)(j + 97);
                    break;
                }
                    
            }
        }
        return answer;
    }
}
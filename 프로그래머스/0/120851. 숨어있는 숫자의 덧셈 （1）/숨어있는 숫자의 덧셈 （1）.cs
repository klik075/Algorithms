using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        for(int i = 0; i < my_string.Length;i++)
        {
            if(my_string[i] == '1')
                answer += 1;
            if(my_string[i] == '2')
                answer += 2;
            if(my_string[i] == '3')
                answer += 3;
            if(my_string[i] == '4')
                answer += 4;
            if(my_string[i] == '5')
                answer += 5;
            if(my_string[i] == '6')
                answer += 6;
            if(my_string[i] == '7')
                answer += 7;
            if(my_string[i] == '8')
                answer += 8;
            if(my_string[i] == '9')
                answer += 9;
            
        }
        return answer;
    }
}
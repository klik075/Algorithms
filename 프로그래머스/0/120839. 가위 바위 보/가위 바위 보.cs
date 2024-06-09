using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        for(int i = 0; i < rsp.Length; i++)
        {
            char temp = rsp[i];
            if(temp == '2')
            {
                answer += '0';

            }
            else if(temp == '0')
            {
                answer += '5';

            }
            else if(temp == '5')
            {
                answer += '2';

            }
        }
        return answer;
    }
}
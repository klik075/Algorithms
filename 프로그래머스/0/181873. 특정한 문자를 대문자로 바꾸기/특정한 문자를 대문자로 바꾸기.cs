using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        char[] arr = alp.ToCharArray();
        for(int i = 0; i< my_string.Length;i++)
        {
            if(my_string[i] == arr[0])
            {
                answer += (char)(my_string[i] - 32);
                continue;
            }
            answer += my_string[i];
        }
        return answer;
    }
}
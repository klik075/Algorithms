using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp = "";
        for(int i = 0 ; i < my_string.Length;i++)
        {
            if(my_string[i] - '0' >= 10)
                temp += " ";
            else
                temp += my_string[i];
        }
        string[] arr = temp.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0 ; i < arr.Length; i++)
        {
            answer += int.Parse(arr[i]);
        }
        return answer;
    }
}
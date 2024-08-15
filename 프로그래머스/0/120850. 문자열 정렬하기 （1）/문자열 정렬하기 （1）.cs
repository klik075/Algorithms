using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
        char[] arr = my_string.ToCharArray();
        List<int> answer = new List<int>();
        for(int i = 0 ; i < arr.Length; i++)
        {
            int result = arr[i] - '0';
            if( 0 <= result && result < 10) // 문자 빼기 숫자
            {
                answer.Add(result);
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}
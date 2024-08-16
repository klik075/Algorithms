using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        List<int> arr = indices.ToList();
        arr.Sort();
        for(int i = 0 ; i < my_string.Length;i++)
        {
            bool isIn = false;
            for(int j = 0 ; j < arr.Count; j++)
            {
                if(arr[j] == i)
                {
                    isIn = true;
                    break;
                }
            }
            
            if(isIn == false)
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        List<string> arr = new List<string>();
        int result =0;
        int temp = 0;
        for(int i = 0 ; i < strings.Length ; i ++)
        {
            if(i == 0)
                arr.Add(strings[i]);
            else
            {
                for(int j = 0 ; j < arr.Count; j++)
                {
                    if(arr[j][n] == strings[i][n])
                    {
                        result = string.Compare(arr[j],strings[i]);
                        if(result > 0)
                        {
                            temp = j;
                            break;
                        }
                        else
                        {
                            temp = j + 1;
                            continue;
                        }
                    }
                    else if( arr[j][n] > strings[i][n])
                    {
                        temp = j;
                        break;
                    }
                    else
                    {
                        temp = j + 1;
                        continue;
                    }
                }
                if(arr.Count <= temp)
                    arr.Add(strings[i]);
                else
                    arr.Insert(temp,strings[i]);
            }
        } 
        answer = arr.ToArray();
        return answer;
    }
}
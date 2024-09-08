using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] arr = my_string.Split(" ",System.StringSplitOptions.RemoveEmptyEntries);
        Queue<int> queue = new Queue<int>();
        for(int i = 0 ; i < arr.Length;i++)
        {
            if(arr[i] == "+")
            {
                arr[i+1] = (queue.Dequeue() + int.Parse(arr[i+1])).ToString();
            }
            else if(arr[i] == "-")
            {
                arr[i+1] = (queue.Dequeue() - int.Parse(arr[i+1])).ToString();
            }
            else
            {
                queue.Enqueue(int.Parse(arr[i]));
            }
        }
        return queue.Dequeue();
    }
}
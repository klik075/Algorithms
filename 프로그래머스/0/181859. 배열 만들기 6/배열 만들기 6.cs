using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        Stack<int> stk = new Stack<int>();
        for(int i = 0 ; i < arr.Length;i++)
        {
            if(stk.Count == 0)
            {
                stk.Push(arr[i]);
            }
            else
            {
                if(stk.Peek() == arr[i])
                {
                    stk.Pop();
                }
                else
                {
                    stk.Push(arr[i]);
                }
            }
        }
        if(stk.Count == 0)
            return new int[] { -1 };
        return stk.Reverse().ToArray();
    }
}
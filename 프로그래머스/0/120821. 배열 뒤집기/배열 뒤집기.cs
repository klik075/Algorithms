using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < num_list.Length ; i++)
        {
            stack.Push(num_list[i]);
        }
        for(int i = 0; i< answer.Length;i++)
        {
            answer[i] = stack.Pop();
        }
        return answer;
    }
}
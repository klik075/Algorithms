using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        List<int> answer = new List<int>();
        int row = board[0]/2;
        int col = board[1]/2;
        int lr = 0;
        int ud = 0;
        foreach(string i in keyinput)
        {
            if(i == "left")
                lr--;
            else if(i == "right")
                lr++;
            else if(i == "up")
                ud++;
            else
                ud--;
            if(lr < -row || lr > row)
            {
                if(lr < 0)
                    lr = -row;
                else
                    lr = row;
            }
            if(ud < -col || ud > col)
            {
                if(ud < 0)
                    ud = -col;
                else
                    ud = col;
            }
        }
        answer.Add(lr);
        answer.Add(ud);
        return answer.ToArray();
    }
}
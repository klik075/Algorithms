using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        for(int i = 0; i < board.GetLength(0); i++)
        {
            for(int j = 0; j < board.GetLength(1); j++)
            {
                if(board[i,j] == 1)
                {
                    for(int r = -1; r <= 1; r++)
                    {
                        for(int l = -1; l <= 1; l++)
                        {
                            int x = i + r;
                            int y = j + l;
                            if(CheckBound(x, y, board.GetLength(1)))
                            {
                                if(board[x,y] == 0)
                                    board[x,y] = 2;
                            }
                        }
                    }
                }
            }
        }
        foreach(int elem in board)
        {
            if(elem == 0)
                answer++;
        }
        return answer;
    }
    
    bool CheckBound(int x, int y, int size)
    {
        if(x < 0 || y < 0 || x >= size || y >= size)
            return false;

        return true;
    }
}
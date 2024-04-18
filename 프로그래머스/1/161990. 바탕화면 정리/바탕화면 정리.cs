using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];    
        char[,] arr = new char[wallpaper.Length,wallpaper[0].Length];
        for(int i =0; i< wallpaper.Length;i++)
        {
            for(int j = 0 ; j < wallpaper[0].Length;j++)
                arr[i,j] = wallpaper[i][j];
        }
        int startPosX = -1;
        int startPosY = -1;
        int endPosX = 0;
        int endPosY = 0;
        for(int y = 0; y < arr.GetLength(0);y++)
        {
            for(int x = 0;x < arr.GetLength(1);x++)
            {
                if(arr[y,x] == '#')
                {
                    if(startPosY == -1)
                    {
                        startPosY = y;
                        endPosY = y+1;
                        break;
                    }
                    else
                    {
                        endPosY = y+1;    
                        break;
                    }
                    
                }
            }
        }
        for(int x = 0;x < arr.GetLength(1);x++)
        {
            for(int y = 0;y<arr.GetLength(0);y++)
            {
                if(arr[y,x] == '#')
                {
                    if(startPosX == -1)
                    {
                        startPosX = x;
                        endPosX = x+1;
                        break;
                    }
                    else
                    {    
                        endPosX = x+1;    
                    }
                        
                }
            }
        }
        answer[0] = startPosY;
        answer[1] = startPosX;
        answer[2] = endPosY;
        answer[3] = endPosX;
        return answer;
    }
}
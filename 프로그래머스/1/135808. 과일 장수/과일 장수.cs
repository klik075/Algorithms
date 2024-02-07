using System;

public class Solution {
    public int solution(int k, int m, int[] score) { //m개 제일 낮은 점수p 한상자 가격 m * p
        int answer = 0;
        int count = score.Length;
        int p = 0;
        int[] newArr = new int[score.Length];
        Array.Sort(score);
        newArr = score;
        while(count / m != 0)
        {
            p = newArr[count - m];
            answer += p * m;
            count -= m;
        }
        return answer;
    }
}
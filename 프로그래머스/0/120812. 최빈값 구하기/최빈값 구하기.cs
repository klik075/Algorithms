using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int max = 1;
        int count = 1;
        int temp = -1;
        Array.Sort(array);
        
        if(array.Length == 1)
            return array[0];
        
        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] == array[i - 1])
                count++;
            else
                count = 1;

            if(count == max)
                temp = -1;
            else if(count > max)
            {
                max = count;
                answer = array[i];
                temp = 0;
            }

        }
        return answer = temp == -1 ? -1 : answer;
    }
}
using System;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = num_list;
        switch(n)
        {
            case 1 : 
                answer = new int[slicer[1]+1];
                Array.Copy(num_list,0,answer,0,answer.Length);
                break;
            case 2 :
                answer = new int[num_list.Length - slicer[0]];
                Array.Copy(num_list,slicer[0],answer,0,answer.Length);
                break;
            case 3 :
                answer = new int[slicer[1] - slicer[0] + 1];
                Array.Copy(num_list,slicer[0],answer,0,answer.Length);
                break;
            case 4 :
                int length = (slicer[1] - slicer[0] + 1) % slicer[2] == 0 ? (slicer[1] - slicer[0] + 1) / slicer[2] : (slicer[1] - slicer[0] + 1)/ slicer[2] + 1;
                answer = new int[length];
                for(int i = 0; i < answer.Length; i++)
                {
                    answer[i] = num_list[slicer[0] + i * slicer[2]];
                }
                break;
        }
        
        return answer;
    }
}
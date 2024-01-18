using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> arr = new List<char>{}; 
        char max = (char)('A'-1);
        char top = (char)('z'+1);
        int temp = 0;
        for(int i = 0 ; i < s.Length; i++)
        {
            arr.Add(s[i]);
        }
        
        for(int i = 0; i <s.Length ;i++)
        {
            for(int j=0;j< arr.Count;j++)
            {
                if(arr[j] > max && arr[j] <= top)
                {
                    max = arr[j]; 
                    temp = j;
                }
            }
            arr.RemoveAt(temp);
            top = (char)(max);
            answer += max;
            max = (char)('A'-1);
        }
        return answer;
    }
}
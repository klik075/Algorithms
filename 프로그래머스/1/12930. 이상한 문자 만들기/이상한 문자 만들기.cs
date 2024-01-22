using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] arr = s.Split(' ');
        string temp = "";
        for(int i =0;i<arr.Count();i++)
        {
            temp = arr[i];
            for(int j = 0; j< temp.Length; j ++)
            {
                if(j % 2 == 0)
                {
                    answer += char.ToUpper(temp[j]);
                }
                else if(j % 2 == 1)
                {
                    answer += char.ToLower(temp[j]);
                }
            }
            if(i != arr.Count()-1)
                answer += ' ';
                    
        }
        return answer;
    }
}
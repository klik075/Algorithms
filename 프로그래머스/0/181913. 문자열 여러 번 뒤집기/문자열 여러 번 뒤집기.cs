using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = my_string;
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i,0];
            int e = queries[i,1];
            
            string sString = answer.Substring(s, e-s+1);
            char[] aString = sString.ToCharArray();
            for(int j = 0; j < sString.Length; j++)
            {
                aString[j] = sString[sString.Length - 1 - j];
            }
            string rString = answer.Remove(s, e-s+1);
            answer = rString.Insert(s, new string(aString));
        }
        return answer;
    }
}
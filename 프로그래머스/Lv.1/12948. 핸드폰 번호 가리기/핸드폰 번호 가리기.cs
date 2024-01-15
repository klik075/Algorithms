public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int count = phone_number.Length;
        int Asterisk = 0;
        if(count > 4)
            Asterisk = count - 4;
        for(int i = 0; i < count; i++)
        {
            if(i < Asterisk)
                answer += "*";
            else
                answer += phone_number[i];
        }
        return answer;
    }
}
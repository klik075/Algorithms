public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        for(int i =0; i < seoul.Length ; i++)
        {
            if(seoul[i] == "Kim")
            {
                answer = string.Format("김서방은 {0}에 있다",i);
                break;
            }
        }
        return answer;
    }
}
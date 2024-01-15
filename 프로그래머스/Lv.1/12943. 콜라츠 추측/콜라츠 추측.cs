public class Solution {
    public int solution(int num) {
        int answer = 0;
        int temp = num;
        while(temp != 1)
        {
            if(temp % 2 == 0)
            {
                temp = temp / 2;
            }
            else if(temp % 2 == 1)
            {
                temp = (temp * 3) + 1; 
            }
            answer++;
            
            if(answer > 500)
            {
                answer = -1;
                break;
            }
        }
        if(num == 1)
            answer = 0;
        return answer;
    }
}
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0;
        int dev =1 ;
        int result;
        while(x/dev != 0)
        {
            result = (x/dev)%10;
            sum += result;
            dev *= 10;
        }
        if(x % sum != 0)
            answer = false;
        return answer;
    }
}
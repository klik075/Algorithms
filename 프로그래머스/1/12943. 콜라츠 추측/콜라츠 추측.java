class Solution {
    public int solution(int num) {
        long longNum = num;
        int count = 0;
        int attemptCount = 500;
        while(count < attemptCount)
        {
            if(longNum == 1)
                break;
            
            if(longNum % 2 == 0)
            {
                longNum /= 2;
            }
            else
            {
                longNum = longNum * 3 + 1;
            }
            
            count++;
        }
        return count >= attemptCount ? -1 : count;
    }
}
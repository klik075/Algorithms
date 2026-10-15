class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for(int i = 1; i <= number; i++)
        {
            answer += myPower(i, limit, power);
        }
        return answer;
    }
    public int myPower(int num, int limit, int power)
    {
        int result = 0;
        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
                result++;
            
            if(result > limit)
                return power;
        }
        return result;
    }
}
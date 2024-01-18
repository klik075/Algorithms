using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long result = money;
        for(int i = 1;i < count +1 ; i++)
        {
            result -= price * i;
        }
        if(result > 0)
            result =0;
        else
            result *= -1;
        return result;
    }
}
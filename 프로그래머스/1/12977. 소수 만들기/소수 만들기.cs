using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int sum = 0;
        int tempCount = 0;
        for(int i = 0; i< nums.Length-2;i++)
        {
            for(int j = i+1;j<nums.Length-1;j++)
            {
                for(int m = j+1;m<nums.Length;m++)
                {
                    sum = nums[i] + nums[j] + nums[m];
                    for(int k = 2; k <= sum/2;k++)
                    {
                        if(sum % k == 0) //약수일 때
                        {
                            tempCount++;
                            break;
                        }
                    }
                    if(tempCount == 0)
                    {
                        answer++;
                    }
                    tempCount = 0;
                }
            }
        } 

        return answer;
    }
}
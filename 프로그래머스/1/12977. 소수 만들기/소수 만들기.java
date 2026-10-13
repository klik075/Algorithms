class Solution {
    public int solution(int[] nums) {
        int answer = 0;

        for(int i = 0; i < nums.length - 2; i++)
        {
            for(int j = i + 1; j < nums.length - 1; j++)
            {
                for(int k = j + 1; k < nums.length; k++)
                {
                    int num = nums[i] + nums[j] + nums[k];
                    if(isMinority(num) == true)
                        answer++;
                }
            }
        }
        return answer;
    }
    
    public boolean isMinority(int num)
    {   
        if(num < 0)
            return false;
        
        if(num == 1)
            return true;
        
        int divide = num/2;
        for(int i = 2; i <= divide; i++)
        {
            if(num % i == 0)
                return false;
        }
        
        return true;
    }
}
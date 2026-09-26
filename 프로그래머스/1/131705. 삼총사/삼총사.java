class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int length = number.length;
        
        for(int left = 0; left < length - 2; left++)
        {
            for(int mid = left+1; mid < length - 1; mid++)
            {
                for(int right = mid+1; right < length; right++)
                {
                    if(number[left] + number[mid] + number[right] == 0)
                        answer++;
                }
            }
        }
        return answer;
    }
}
class Solution {
    public long solution(long n) {
        int[] count = new int[10];

        while (n > 0)
        {
            int number = (int)(n % 10);
            count[number] += 1;
            n /= 10;
        }
        
        StringBuilder sb = new StringBuilder();
        
        for(int number = count.length - 1; number >= 0; number--)
        {
            if(count[number] == 0)
                continue;
            
            String character = String.valueOf(number);
            
            for(int i = 0; i < count[number]; i++)
            {
                sb.append(character);
            }
        }
        
        long answer = Long.parseLong(sb.toString());
        return answer;
    }
}
class Solution {
    public int[] solution(int n, int m) {
        int min = 1;
        int max = min;
        int maxTry = n * m;
        
        while(min < maxTry)
        {
            if(min % n == 0 && min % m == 0)
                break;
            
            if(n % min == 0 && m % min == 0)
                max = min;
            
            min++;
        }
        
        return new int[]{max, min};
    }
}
class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        while(n/a > 0)
        {
            int share = n/a;
            int refillBottle = share * b;
            n = n - share * a + refillBottle;
            answer += refillBottle;
        }
        return answer;
    }
}
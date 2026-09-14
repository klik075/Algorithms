class Solution {
    public boolean solution(int x) {
        boolean answer = true;
        long denominator = 0;
        long number = x;
        while(number > 0)
        {
            denominator += number % 10;
            number /= 10;
        }
        return answer = x % denominator == 0 ? true : false;
    }
}
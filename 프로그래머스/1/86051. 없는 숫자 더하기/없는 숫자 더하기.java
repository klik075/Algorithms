import java.util.Arrays;

class Solution {
    public int solution(int[] numbers) {
        int total = 45;
        int answer = total - Arrays.stream(numbers).sum();
        return answer;
    }
}
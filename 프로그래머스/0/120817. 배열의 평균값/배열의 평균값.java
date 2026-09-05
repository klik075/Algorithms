import java.util.Arrays;

class Solution {
    public double solution(int[] numbers) {
        
        double answer = Arrays.stream(numbers)
            .average()
            .orElse(0);
            
        return answer;
    }
}
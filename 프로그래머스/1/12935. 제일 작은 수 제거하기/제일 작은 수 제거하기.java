import java.util.Arrays;
class Solution {
    public int[] solution(int[] arr) {
        int[] answer = {-1};
            
        if(arr.length == 1)
            return answer;
        
        int min = Arrays.stream(arr)
            .min()
            .orElse(0);
        
        answer = Arrays.stream(arr)
            .filter(n -> n > min)
            .toArray();
        return answer;
    }
}
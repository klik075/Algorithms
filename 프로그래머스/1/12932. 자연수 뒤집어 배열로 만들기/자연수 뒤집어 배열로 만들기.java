import java.util.List;
import java.util.ArrayList;

class Solution {
    public int[] solution(long n) {
        List<Integer> arr = new ArrayList<>();
        long i = 1;
        while(n / i > 0)
        {
            arr.add((int)((n / i) % 10));
            i *= 10;
        }
        
        int[] answer = arr.stream()
            .mapToInt(Integer::intValue)
            .toArray();
        return answer;
    }
}
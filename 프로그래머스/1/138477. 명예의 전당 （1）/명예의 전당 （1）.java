import java.util.Comparator;
import java.util.Optional;
import java.util.Arrays;

class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.length];
        for(int i = 0; i < score.length; i++)
        {
            Optional<Integer> result = Arrays.stream(score)
                .boxed()
                .limit(i+1)
                .sorted(Comparator.reverseOrder())
                .limit(k)
                .min(Comparator.naturalOrder());
            
            answer[i] = result.orElse(0);
        }
        return answer;
    }
}
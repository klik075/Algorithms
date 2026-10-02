import java.util.Arrays;
import java.util.stream.Stream;
import java.util.Comparator;

class Solution {
    public String[] solution(String[] strings, int n) {
        String[] answer = Arrays.stream(strings)
            .sorted(Comparator.comparing((String s) -> s.charAt(n))
                      .thenComparing(Comparator.naturalOrder())
            )
            .toArray(String[]::new);
        return answer;
    }
}
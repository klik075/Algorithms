import java.util.stream.Collectors;
import java.util.Comparator;

class Solution {
    public String solution(String s) {
        String answer = s.chars()
            .boxed()
            .sorted(Comparator.reverseOrder())
            .map(c -> String.valueOf((char) c.intValue()))
            .collect(Collectors.joining());
        
        return answer;
    }
}
import java.util.stream.IntStream;
import java.util.stream.Collectors;

class Solution {
    public String solution(int n) {

        String answer = IntStream.range(0, n)
            .mapToObj(index -> index % 2 == 0 ? "수" : "박")
            .collect(Collectors.joining());
        return answer;
    }
}
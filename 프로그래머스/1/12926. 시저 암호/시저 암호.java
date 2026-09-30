import java.util.stream.Collectors;

class Solution {
    public String solution(String s, int n) {
        StringBuilder answer = new StringBuilder();
        
        s.chars()
            .forEach(c -> {
                if (c >= 'a' && c <= 'z') {
                    c = 'a' + (c - 'a' + n) % 26;
                } else if (c >= 'A' && c <= 'Z') {
                    c = 'A' + (c - 'A' + n) % 26;
                }
                answer.append((char) c);
            });
        return answer.toString();
    }
}
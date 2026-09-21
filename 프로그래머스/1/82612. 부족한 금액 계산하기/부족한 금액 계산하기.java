import java.util.stream.IntStream;
class Solution {
    public long solution(int price, int money, int count) {
        long total = IntStream.rangeClosed(1, count)
            .mapToLong(n -> (long)n * price)
            .sum();
        
        return total >= money ? total - money : 0;
    }
}
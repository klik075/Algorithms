import java.util.List;
import java.util.ArrayList;
import java.util.stream.IntStream;

class Solution {
    public int solution(int n) {
        List<Integer> arr = new ArrayList<>();
        
        while(n > 0)
        {
            int num = n % 3;
            arr.add(num);
            n = n / 3;
        }
        
        int sum = IntStream.rangeClosed(1, arr.size())
            .map(num -> {
                int index = num - 1;
                if(arr.get(index) == 0)
                    return 0;
                
                int Multiplication = 1;
                for(int i = arr.size() - num; i > 0; i--){
                    Multiplication *= 3;
                }
                
                return arr.get(index) * Multiplication;
            })
            .sum();
        return sum;
    }
}
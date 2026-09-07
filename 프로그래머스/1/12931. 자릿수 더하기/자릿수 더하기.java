import java.util.*;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int line = 1;
        
        while(n / line != 0) {
            answer += (n / line) % 10;
            System.out.print(n % line + " ");
            line *= 10;
        }
        

        return answer;
    }
}
public class Solution {
    public int solution(int[,] lines) {
        int[] counts = new int[201];
        
        for (int i = 0; i < lines.GetLength(0); i++) {
            int start = lines[i, 0] + 100;
            int end = lines[i, 1] + 100;
            
            for (int j = start; j < end; j++) {
                counts[j]++;
            }
        }
        
        int answer = 0;
        for (int i = 0; i < counts.Length; i++) {
            if (counts[i] > 1) {
                answer++;
            }
        }
        
        return answer;
    }
}
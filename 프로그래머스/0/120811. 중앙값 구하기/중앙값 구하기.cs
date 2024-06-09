using System;
using System.Linq;
public class Solution {
    public int solution(int[] array) {
        int answer = array.OrderBy(x => x).ToArray()[array.Length / 2];
        
        return answer;
    }
}
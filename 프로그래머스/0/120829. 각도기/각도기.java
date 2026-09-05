class Solution {
    public int solution(int angle) {
        int answer = (angle / 90) + (angle <= 90 ? 1 : 2);
        return answer;
    }
}
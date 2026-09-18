class Solution {
    public String solution(String s) {
        String answer = "";
        int halfIndex = s.length() / 2;
        
        if(s.length() % 2 == 0){
            answer = String.format("%c%c", s.charAt(halfIndex - 1), s.charAt(halfIndex));
        }
        else{
            answer = String.format("%c", s.charAt(halfIndex));
        }
        return answer;
    }
}
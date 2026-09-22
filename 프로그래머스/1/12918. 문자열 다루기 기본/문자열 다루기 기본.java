
class Solution {
    public boolean solution(String s) {
        int stringLength = s.length();
        
        if(stringLength != 4 && stringLength != 6)
            return false;
        
        long count = s.chars()
            .filter(c -> '0' <= c && c <= '9')
            .count();
        
        return stringLength == count;
    }
}
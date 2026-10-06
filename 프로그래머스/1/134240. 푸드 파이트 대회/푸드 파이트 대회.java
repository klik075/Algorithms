class Solution {
    public String solution(int[] food) {
        StringBuilder sb = new StringBuilder();
        int totalLength = 0;
        for(int i = 1; i < food.length; i++)
        {
            int count = food[i]/2 * 2;
            String numberString = String.valueOf(i).repeat(count);
            sb.insert(totalLength/2, numberString);
            totalLength += count;
        }
        sb.insert(totalLength/2, "0");
        return sb.toString();
    }
}
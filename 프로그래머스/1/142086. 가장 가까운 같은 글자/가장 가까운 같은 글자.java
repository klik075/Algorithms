class Solution {
    public int[] solution(String s) {
        int[] answer = new int[s.length()];
        for(int i = s.length() - 1; i >= 0; i--)
        {
            char currentIndexChar = s.charAt(i);
            int count = 0;
            boolean isFind = false;
            for(int j = i - 1; j >= 0; j--)
            {
                count++;
                char compIndexChar = s.charAt(j);
                if(currentIndexChar == compIndexChar)
                {
                    isFind = true;
                    break;
                }
            }
            count = isFind ? count : -1;
            answer[i] = count;
        }
        return answer;
    }
}
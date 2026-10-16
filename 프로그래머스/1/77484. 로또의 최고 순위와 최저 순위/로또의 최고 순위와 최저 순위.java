import java.util.Arrays;

class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = {0, 0};
        int zeroCount = 0;
        int numCount = 0; 
        for(int i = 0; i < lottos.length; i++)
        {
            if(lottos[i] == 0)
            {
                zeroCount++;
                continue;
            }
            
            int lotto = lottos[i];
            int[] result = Arrays.stream(win_nums)
                    .filter(n -> n == lotto)
                    .toArray();
            numCount = result.length == 0 ? numCount : numCount + 1;
        }
        answer[1] = lottosRank(numCount);
        answer[0] = lottosRank(numCount + zeroCount);
        
        return answer;
    }
    public int lottosRank(int num)
    {
        switch(num)
        {
            case 6:
                return 1;
            case 5:
                return 2;
            case 4:
                return 3;
            case 3:
                return 4;
            case 2:
                return 5;
            default:
                return 6;
        }
    }
}
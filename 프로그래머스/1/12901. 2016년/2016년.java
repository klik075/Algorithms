class Solution {
    public String solution(int a, int b) {
        int[] days = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int totalDay = 4;
        String answer = "";
        
        for(int i = 1; i <= a; i++)
        {
            if(i < a)
            {
                totalDay += days[i];
                continue;
            }
                
            totalDay += b;
        }
        switch(totalDay % 7) {
            case 0:
                answer = "SUN";
                break;
            case 1:
                answer = "MON";
                break;  
            case 2:
                answer = "TUE";
                break;
            case 3:
                answer = "WED";
                break;
            case 4:
                answer = "THU";
                break;
            case 5:
                answer = "FRI";
                break;
            case 6:
                answer = "SAT";
                break;
        }
        return answer;
    }
}
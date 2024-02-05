public enum Day
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT
        }
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        Day day;
        int totalDay = 4;
        for(int m = 1 ; m < a; m++)
        {
            if(m == 2)
            {
                totalDay += 29;
                continue;
            }
            if(m < 7)
            {
                if(m % 2 == 0)
                {
                    totalDay += 30;
                    continue;
                }
                if(m % 2 == 1)
                {
                    totalDay += 31;
                    continue;
                }
            }
            else if(m == 7)
            {
                totalDay += 31;
                continue;
            }
            else if(m > 7)
            {
                if(m % 2 == 0)
                {
                    totalDay += 31;
                    continue;
                }
                if(m % 2 == 1)
                {
                    totalDay += 30;
                    continue;
                }
            }
        }
        totalDay += b;
        day = (Day)(totalDay % 7);
        switch(day)
        {
            case Day.SUN:
                return answer = "SUN";
            case Day.MON:
                return answer = "MON";
            case Day.TUE:
                return answer = "TUE";
            case Day.WED:
                return answer = "WED";
             case Day.THU:
                return answer = "THU";
            case Day.FRI:
                return answer = "FRI";
            case Day.SAT:
                return answer = "SAT";
        }
        return answer;
    }
}
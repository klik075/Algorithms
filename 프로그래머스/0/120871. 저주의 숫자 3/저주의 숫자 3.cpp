#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    for(int i = 1; i <= n; i++)
    {
        answer++;
        
        int mul = 1;
        
        while(answer >= mul)
        {
            if(answer % 3 == 0)
            {
                answer++;
                continue;
            }
            
            int temp = answer / mul;
            if(temp % 10 == 3)
            {
                answer++;
                mul = 1;
                continue;
            }
            
            mul *= 10;
        }
    }
    return answer;
}
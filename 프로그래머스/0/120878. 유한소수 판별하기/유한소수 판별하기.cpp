#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(int a, int b) {
    int answer = 1;
    
    while(true)
    {
        int min = std::min(a, b);
        int i = 2;
        for(i; i <= min; i++)
        {
            if(a % i == 0 && b % i == 0)
            {
                a /= i;
                b /= i;
                break;
            }
        }
        
        if(i >=  min + 1)
            break;
    }
    
    bool loop = true;
    while(loop)
    {
       for(int i = 2; i <= b; i++)
        {
            if(b % i == 0)
            {
                b /= i;
                if(i == 2 || i == 5)
                    break;
                else
                {
                    answer = 2;
                    loop = false;
                    break;
                }
            }
        }
        if(b == 1)
            break;
    }
    
    return answer;
}
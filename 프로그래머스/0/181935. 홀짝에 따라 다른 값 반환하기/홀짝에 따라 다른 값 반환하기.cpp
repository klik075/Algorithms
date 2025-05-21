#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    bool iseven = n % 2 == 0 ? true : false;
    int i = iseven == true ? 2 : 1;
    for(i; i <= n; i = i + 2)
    {
        if(iseven)
            answer += i * i;
        else
            answer += i;
    }
    return answer;
}
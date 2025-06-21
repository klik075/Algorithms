#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
using namespace std;

int solution(int a, int b) {
    int answer = 0;
    if(a % 2 != 0 && b % 2 != 0)
        answer = pow(a, 2) + pow(b, 2);
    else if(a % 2 != 0 || b % 2 != 0)
        answer = 2 * (a + b);
    else
        answer = abs(a - b);
    return answer;
}
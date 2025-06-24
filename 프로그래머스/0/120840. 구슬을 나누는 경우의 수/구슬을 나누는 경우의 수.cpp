#include <string>
#include <vector>

using namespace std;

long solution(int balls, int share) {
    double answer = 0;
    double mul = 1;
    double mod = 1;
    for(int i = balls; i > balls - share; i--)
        mul *= i;
    for(int i = share; i >= 1; i--)
        mod *= i; 
    answer = mul/mod;
    return (long)answer;
}
#include <string>
#include <vector>

using namespace std;

int solution(int chicken) {
    int answer = 0;
    while(chicken > 9)
    {
        chicken -= 9;
        answer++;
    }
    return answer;
}
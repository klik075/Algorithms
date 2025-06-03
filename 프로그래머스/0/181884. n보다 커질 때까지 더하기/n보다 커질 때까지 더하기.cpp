#include <string>
#include <vector>

using namespace std;

int solution(vector<int> numbers, int n) {
    int answer = 0;
    for(auto elm : numbers)
    {
        answer += elm;
        if(answer > n)
            break;
    }
    return answer;
}
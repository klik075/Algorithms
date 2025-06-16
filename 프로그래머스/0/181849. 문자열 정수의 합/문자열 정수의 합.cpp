#include <string>
#include <vector>

using namespace std;

int solution(string num_str) {
    int answer = 0;
    for(auto elem : num_str)
    {
        if(isdigit(elem))
            answer += elem - '0';
    }
    return answer;
}
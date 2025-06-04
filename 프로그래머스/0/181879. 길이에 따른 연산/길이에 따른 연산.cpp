#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 1;
    
    for(auto elem : num_list)
    {
        if(num_list.size() >= 11)
            answer += elem;
        else
            answer *= elem;
    }
    
    return answer = num_list.size() >= 11 ? answer - 1: answer;
}
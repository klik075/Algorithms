#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    int mul = 1;
    int com = 0;
    for(auto num : num_list)
    {
        mul *= num;
        com += num;
    }
    answer = mul < com * com ? 1 : 0; 
    return answer;
}
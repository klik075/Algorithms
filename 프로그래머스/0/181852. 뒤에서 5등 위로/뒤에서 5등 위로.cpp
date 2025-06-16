#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer(num_list);
    sort(answer.begin(), answer.end());
    for(int i = 0; i < 5; i++)
        answer.erase(answer.begin());
    return answer;
}
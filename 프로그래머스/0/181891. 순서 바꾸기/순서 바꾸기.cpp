#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list, int n) {
    vector<int> answer;
    for(int i = num_list.size() - 1; i >= 0; i--)
    {
        if(i > n - 1)
            answer.insert(answer.begin(), num_list[i]);
        else
            answer.insert(answer.begin() + num_list.size() - n, num_list[i]);
    }
    return answer;
}
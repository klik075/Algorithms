#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> arr, vector<int> delete_list) {
    vector<int> answer = arr;
    for(auto i : delete_list)
    {
        for(auto j : answer)
        {
            if(i == j)
            {
                auto new_end = remove(answer.begin(), answer.end(), i);
                answer.erase(new_end, answer.end());
            }
        }
    }
    
    return answer;
}
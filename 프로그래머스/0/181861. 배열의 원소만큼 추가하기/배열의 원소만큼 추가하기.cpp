#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer;
    for(auto elem : arr)
    {
        for(int i = elem; i > 0; i--)
            answer.push_back(elem);
    }
    return answer;
}
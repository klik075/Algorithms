#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr, int n) {
    vector<int> answer(arr);
    int i = arr.size() % 2 != 0 ? 0 : 1;
    for(; i < arr.size(); i = i + 2)
        answer[i] = answer[i] + n;
    return answer;
}
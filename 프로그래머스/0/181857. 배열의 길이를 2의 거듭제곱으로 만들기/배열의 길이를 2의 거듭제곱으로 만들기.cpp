#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer(arr);
    int num = 1;
    while(arr.size() > num)
        num *= 2;
    
    for(int i = arr.size(); i < num; i++)
        answer.push_back(0);
    return answer;
}
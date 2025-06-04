#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer;
    for(auto elem : arr)
    {
        if(elem >= 50 && elem % 2 == 0)
            answer.push_back(elem / 2);
        else if(elem < 50 && elem % 2 != 0)
            answer.push_back(elem * 2);
        else
            answer.push_back(elem);
            
    }
    return answer;
}
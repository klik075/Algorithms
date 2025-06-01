#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer;
    for(int i = 0; i < arr.size(); i++)
    {
        if(arr[i] == 2)
            answer.push_back(i);
    }
    if(answer.size() == 0)
    {
        answer.push_back(-1);
        return answer;
    }
    else if(answer.size() == 1)
    {
        answer.clear();
        answer.push_back(2);
        return answer;
    }
    else
    {
        int maxindex = *max_element(answer.begin(), answer.end());
        int minindex = *min_element(answer.begin(), answer.end());
        answer.clear();
        for(int i = minindex; i <= maxindex; i++)
        {
            answer.push_back(arr[i]);
        }
    }
    
    return answer;
}
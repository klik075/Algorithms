#include <string>
#include <vector>
#include <unordered_set>
using namespace std;

vector<int> solution(vector<int> arr, int k) {
    vector<int> answer;
    unordered_set<int> set;
    int temp = k;
    for(auto elem : arr)
    {
        auto it = set.find(elem);
        if(it == set.end())
        {
            set.insert(elem);
            answer.push_back(elem);
            temp--;
        }
        
        if(temp == 0)
            break;
    }
    if(answer.size() != k)
    {
        for(int i = answer.size(); i < k; i++)
            answer.push_back(-1);
    }
    return answer;
}
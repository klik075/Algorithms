#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> numlist, int n) {
    vector<pair<int,int>> _map;
    vector<int> answer;
    
    for(auto i : numlist)
        _map.push_back({abs(n-i), -i});
    
    sort(_map.begin(),_map.end());

    for(auto [distance, num] : _map)
        answer.push_back(abs(num));
    
    return answer;
}
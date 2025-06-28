#include <string>
#include <vector>
#include <queue>
#include <map>
using namespace std;

int solution(vector<int> array) {
    
    if(array.size() == 1)
        return array.back();
    
    map<int,int> map;
    for(auto num : array)
        map[num]++;
    
    priority_queue<pair<int, int>> max_pq;
    for (auto const& [num, count] : map)
        max_pq.push({count, num});
    
    pair<int,int> pair1 = max_pq.top();
    max_pq.pop();
    
    if (max_pq.empty()) {
        return pair1.second;
    }
    
    pair<int, int> pair2 = max_pq.top();
    return pair1.first == pair2.first ? -1 : pair1.second;
}
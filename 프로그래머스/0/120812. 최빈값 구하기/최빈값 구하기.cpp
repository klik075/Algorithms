#include <string>
#include <vector>
#include <queue>
#include <map>
using namespace std;

int solution(vector<int> array) {
    int answer = 0;
    if(array.size() == 1)
        return array.back();
    
    priority_queue<pair<int,int>> max_pq;
    map<int,int> map;
    
    for(auto i : array)
    {
        map[i] += 1;
        max_pq.push({map[i], i});
    }
    
    pair<int,int> pair1 = max_pq.top();
    max_pq.pop();
    pair<int,int> pair2 = max_pq.top();
    max_pq.pop();
    
    if(pair1.first == pair2.first)
        answer = -1;
    else
        answer = pair1.second;

    return answer;
}
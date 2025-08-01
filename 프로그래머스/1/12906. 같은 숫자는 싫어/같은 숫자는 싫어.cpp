#include <vector>
#include <iostream>
#include <queue>;

using namespace std;

vector<int> solution(vector<int> arr) 
{
    queue<int> _queue;
    vector<int> answer;
    
    _queue.push(arr[0]);
    for(int i = 1; i < arr.size(); i++)
    {
        if(_queue.back() != arr[i])
            _queue.push(arr[i]);
    }
    
    while (!_queue.empty()) 
    {
        answer.push_back(_queue.front());
        _queue.pop();
    }
    return answer;
}
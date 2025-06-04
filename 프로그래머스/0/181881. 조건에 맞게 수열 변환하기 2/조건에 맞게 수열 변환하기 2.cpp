#include <string>
#include <vector>

using namespace std;

int solution(vector<int> arr) {
    int answer = 0;
    vector<int> prev = arr;
    vector<int> next;
    
    while(true)
    {
        answer++;
        
        for(int i = 0; i < prev.size(); i++)
        {
            if(prev[i] >= 50 && prev[i] % 2 == 0)
                next.push_back(prev[i] % 2);
            else if(prev[i] < 50 && prev[i] % 2 != 0)
                next.push_back(prev[i] * 2 + 1);
            else
                next.push_back(prev[i]);
        }

        for(int i = 0; i < prev.size(); i++)
        {
            if(prev[i] != next[i])
                break;

            if(i == prev.size() - 1 && prev[i] == next[i])
                return answer - 1;
        }
        
        prev = next;
        next.clear();
    }
    
    return answer;
}
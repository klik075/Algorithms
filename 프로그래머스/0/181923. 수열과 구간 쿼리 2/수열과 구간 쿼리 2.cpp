#include <string>
#include <vector>
#include <climits>
using namespace std;

vector<int> solution(vector<int> arr, vector<vector<int>> queries) {
    vector<int> answer(queries.size(), INT_MAX);
    for(int j = 0; j < queries.size(); j++)
    {
        int s = queries[j][0];
        int e = queries[j][1];
        int k = queries[j][2];
        
        for(int i = s; i <= e; i++)
        {
            if(arr[i] > k)
            {
                if(arr[i] < answer[j])
                    answer[j] = arr[i];
            }
        }
        
        if(answer[j] == INT_MAX)
            answer[j] = -1;
    }
    return answer;
}
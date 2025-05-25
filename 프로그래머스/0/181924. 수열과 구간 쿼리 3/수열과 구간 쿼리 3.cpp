#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr, vector<vector<int>> queries) {
    vector<int> answer = arr;
    for(int i = 0 ; i < queries.size(); i++)
    {
        int x = queries[i][0];
        int y = queries[i][1];
        
        int temp = answer[x];
        answer[x] = answer[y];
        answer[y] = temp;
    }
    return answer;
}
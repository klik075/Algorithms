#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr, vector<vector<int>> intervals) {
    vector<int> answer;
    for(int i = 0; i < intervals.size(); i++)
    {
        int a = intervals[i][0];
        int b = intervals[i][1];
        for(a; a <= b; a++)
            answer.push_back(arr[a]);
    }
    return answer;
}
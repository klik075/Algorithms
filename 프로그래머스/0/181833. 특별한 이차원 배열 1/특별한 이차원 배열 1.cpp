#include <string>
#include <vector>

using namespace std;

vector<vector<int>> solution(int n) {
    vector<vector<int>> answer(n, vector<int>(n));
    for(int i = 0; i < answer.size(); i++)
    {
        for(int j = 0; j < answer[i].size(); j++)
            answer[i][j] = i == j ? 1 : 0;
    }
    return answer;
}
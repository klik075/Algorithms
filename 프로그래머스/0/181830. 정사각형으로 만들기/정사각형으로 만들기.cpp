#include <string>
#include <vector>

using namespace std;

vector<vector<int>> solution(vector<vector<int>> arr) {
    int colsize = arr.size();
    int rowsize = 0;
    
    for(int i = 0; i < arr.size(); i++)
    {
        if(arr[i].size() > rowsize)
            rowsize = arr[i].size();
    }
    
    int size = colsize > rowsize ? colsize : rowsize;
    vector<vector<int>> answer(size, vector<int>(size));
    
    for(int i = 0; i < arr.size(); i++)
    {
        for(int j = 0; j < arr[i].size(); j++)
            answer[i][j] = arr[i][j];
    }
    
    return answer;
}
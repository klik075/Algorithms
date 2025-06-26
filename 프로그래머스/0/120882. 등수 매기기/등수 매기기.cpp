#include <string>
#include <vector>
#include <algorithm>
#include <map>
using namespace std;

vector<int> solution(vector<vector<int>> score) {
    vector<int> answer;
    vector<float> arr;
    map<int,int> scoremap;
    int rank = 1;
    int comp = -1;
    for(int i = 0; i < score.size(); i++)
    {
        int eng = score[i][0];
        int mat = score[i][1];
        int avg = eng + mat;
        answer.push_back(avg);
        arr.push_back(avg);
    }
    sort(arr.begin(), arr.end(), greater<int>());
    
    for(int i = 0; i < arr.size(); i++)
    {
        if(comp == arr[i])
            rank++;
        else
            scoremap[arr[i]] = rank++;
        
        comp = arr[i];
    }
    
    for(int i = 0; i < answer.size(); i++)
        answer[i] = scoremap[answer[i]];
    
    return answer;
}
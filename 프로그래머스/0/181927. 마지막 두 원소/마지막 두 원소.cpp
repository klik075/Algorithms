#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer;
    answer = num_list;
    int lastnum = answer[answer.size() - 1];
    int prevnum = answer[answer.size() - 2];
    if(lastnum > prevnum)
    {
        answer.push_back(lastnum - prevnum);
    }
    else
    {
        answer.push_back(lastnum * 2);
    }
    return answer;
}
#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<string> solution(string my_string) {
    vector<string> answer;
    for(int i = 0; i < my_string.size(); i++)
    {
        string temp = my_string.substr(i,my_string.size() - i);
        answer.push_back(temp);
    }
    sort(answer.begin(),answer.end());
    return answer;
}
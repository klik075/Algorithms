#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<string> solution(vector<string> str_list) {
    vector<string> answer;
    auto lit = find(str_list.begin(), str_list.end(), "l");
    auto rit = find(str_list.begin(), str_list.end(), "r");
    int start = 0;
    int end = str_list.size();
    int lindex = distance(str_list.begin(), lit);
    int rindex = distance(str_list.begin(), rit);
    
    if(lindex == str_list.size() && rindex == str_list.size())
            return answer;
    
    if(lit != str_list.end() || rit != str_list.end())
    {
        if(lindex < rindex)
            end = lindex;
        else
            start = rindex + 1;
    }
    
    for(int i = start; i < end; i++)
    {
        answer.push_back(str_list[i]);
    }
    
    return answer;
}
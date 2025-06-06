#include <string>
#include <vector>

using namespace std;

vector<string> solution(vector<string> strArr) {
    vector<string> answer;
    for(auto elem : strArr)
    {
        size_t index = elem.find("ad");
        if (index == string::npos)
            answer.push_back(elem);
    }
    return answer;
}
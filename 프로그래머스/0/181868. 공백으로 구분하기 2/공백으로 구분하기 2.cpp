#include <string>
#include <vector>
#include <sstream>
using namespace std;

vector<string> solution(string my_string) {
    vector<string> answer;
    stringstream ss(my_string);
    string temp;
    while(getline(ss,temp,' '))
    {
        if(!temp.empty())
            answer.push_back(temp);
    }
    return answer;
}
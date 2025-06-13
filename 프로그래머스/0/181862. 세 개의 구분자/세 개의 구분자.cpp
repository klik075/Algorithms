#include <string>
#include <vector>
#include <sstream>
#include <algorithm>
using namespace std;

vector<string> solution(string myStr) {
    vector<string> answer;
    replace(myStr.begin(),myStr.end(),'a',' ');
    replace(myStr.begin(),myStr.end(),'b',' ');
    replace(myStr.begin(),myStr.end(),'c',' ');
    stringstream ss(myStr);
    string temp;
    while(getline(ss,temp,' '))
    {
        if(!temp.empty())
            answer.push_back(temp);
    }
    if(answer.size() == 0)
        answer.push_back("EMPTY");
    return answer;
}
#include <string>
#include <vector>
#include <sstream>
using namespace std;

vector<int> solution(string myString) {
    vector<int> answer;
    string temp = myString + "x";
    stringstream ss(temp);
    
    while(getline(ss,temp,'x'))
        answer.push_back(temp.size());
    
    return answer;
}
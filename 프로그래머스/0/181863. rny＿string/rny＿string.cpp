#include <string>
#include <vector>
#include <sstream>
using namespace std;

string solution(string rny_string) {
    string answer = "";
    stringstream ss(rny_string);
    string temp;
    
    while(getline(ss,temp,'m'))
        answer += temp + "rn";
    
    if(rny_string.back() == 'm')
        return answer;
    
    return answer.substr(0, answer.size() - 2);
}
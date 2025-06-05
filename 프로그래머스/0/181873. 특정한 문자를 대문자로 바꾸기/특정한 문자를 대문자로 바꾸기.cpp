#include <string>
#include <vector>
#include <algorithm>
#include <cctype>
using namespace std;

string solution(string my_string, string alp) {
    string answer = my_string;
    replace(answer.begin(), answer.end(), alp[0], static_cast<char>(::toupper(alp[0])));
    
    return answer;
}
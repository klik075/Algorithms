#include <string>
#include <vector>

using namespace std;

string solution(string myString, string pat) {
    int index = myString.rfind(pat) + pat.size();
    string answer = myString.substr(0, index);
    return answer;
}
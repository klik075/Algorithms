#include <string>
#include <vector>
#include <algorithm>
using namespace std;

string solution(string myString) {
    string answer = myString;
    transform(answer.begin(), answer.end(), answer.begin(), ::tolower);
    return answer;
}
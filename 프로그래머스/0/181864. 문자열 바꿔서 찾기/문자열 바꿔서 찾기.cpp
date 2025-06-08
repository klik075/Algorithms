#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(string myString, string pat) {
    string answer = myString;
    replace(answer.begin(), answer.end(), 'A','C');
    replace(answer.begin(), answer.end(), 'B','A');
    replace(answer.begin(), answer.end(), 'C','B');
    return (answer.find(pat) != string::npos) ? 1 : 0;
}
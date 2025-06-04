#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(string myString, string pat) {
    int answer = 0;
    string mystr = myString;
    string patstr = pat;
    
    transform(mystr.begin(), mystr.end(), mystr.begin(), [](unsigned char c){ return tolower(c); });
    transform(patstr.begin(), patstr.end(), patstr.begin(), [](unsigned char c){ return tolower(c); });
    
    auto it = mystr.find(patstr);
    return answer = it != string::npos ? 1 : 0;
}